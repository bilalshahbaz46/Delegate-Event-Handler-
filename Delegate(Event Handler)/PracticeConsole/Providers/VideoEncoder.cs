using PracticeConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PracticeConsole
{
    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler videoEncodedEvent;


        public event EventHandler<VideoEventArgs> VideoEncodedEvent;
        public void Encode(Video video)
        {

            Console.WriteLine($"Your Video with the Title: \"{video.Title}\" is being Encoded now...");
            Thread.Sleep(1000);

            var i = 0;

            while (i <= 100)
            {
                Console.SetCursorPosition(1,3);
                Console.Write($"{i}%");
                Console.SetCursorPosition(1, 3);
                Thread.Sleep(20);
                if(i == 100)
                {
                    Thread.Sleep(1000);
                }
                i++;
            }
            Console.SetCursorPosition(1,4);

            Console.WriteLine("Video Encoded");

            VideoEncoded(video);
        }

        protected virtual void VideoEncoded(Video video)
        {
            if (VideoEncodedEvent != null)
                VideoEncodedEvent(this, new VideoEventArgs() { Video = video});
        }
    }
}
