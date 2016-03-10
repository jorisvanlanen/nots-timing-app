using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Timing_app
{
    class TestClass
    {
        private Stopwatch timer;
        private WebClient downloader;
        private TimeSpan elapsed;
        private string elapsedTime;

        public void SetUp()
        {
            timer = new Stopwatch();
            downloader = new WebClient();
        }

        public void StartTest()
        {
            timer.Start();
            for (int i = 0; i < 100; i++)
            {
                downloader.DownloadFile("http://ftp.telfort.nl/pub/test/1megabyte.bin", @"c:\tempdownload\1mb.txt");
            }

            timer.Stop();
            elapsed = timer.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                elapsed.Hours, elapsed.Minutes, elapsed.Seconds,
                elapsed.Milliseconds / 10);

            Console.WriteLine("RunTime when downloading 1MB 100 times is: " + elapsedTime);

            // Now go for 100MB
            timer.Reset();
            timer.Start();
            downloader.DownloadFile("http://ftp.telfort.nl/pub/test/100megabyte.bin", @"c:\tempdownload\100mb.txt");
            timer.Stop();

            elapsed = timer.Elapsed;

            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                elapsed.Hours, elapsed.Minutes, elapsed.Seconds,
                elapsed.Milliseconds / 10);
            Console.WriteLine("RunTime when downloading 100MB 1 time is: " + elapsedTime);

            // Finally
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
