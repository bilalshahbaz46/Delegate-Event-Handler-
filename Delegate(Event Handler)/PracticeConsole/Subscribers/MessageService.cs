using PracticeConsole.Models;
using System;
using System.Threading;

namespace PracticeConsole
{
    public class MessageService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: The message is being sent over..." + args.Video.Title);
            Thread.Sleep(1000); 
        }
    }
}
