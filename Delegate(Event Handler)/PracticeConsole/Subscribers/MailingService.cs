using PracticeConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PracticeConsole
{
    public class MailingService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs args)
        {
            Console.WriteLine("Mailing Service: The mail is being sent over..." + args.Video.Title);
            Thread.Sleep(1000);
        }
    }
}
