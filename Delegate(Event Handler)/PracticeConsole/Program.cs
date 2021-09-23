using System;

namespace PracticeConsole
{
    public delegate string MyDel(string str);
    public class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter the video Title:");
            var videoTitle = Console.ReadLine();

            Video newVideo = new Video { Title = videoTitle };

            var VEncoder = new VideoEncoder(); //provider
            var mailService = new MailingService(); //subscriber
            var messageService = new MessageService(); //subscriber

            VEncoder.VideoEncodedEvent += mailService.OnVideoEncoded;  
            VEncoder.VideoEncodedEvent += messageService.OnVideoEncoded;

            VEncoder.Encode(newVideo);

        }

    }
}
