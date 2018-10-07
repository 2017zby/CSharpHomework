using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//书上例题
namespace ConsoleApp1
{
    public class DownloadEventArgs:EventArgs
    {
        public double Percent;
    }
    public delegate void DownloadEventHandler(object sender, DownloadEventArgs e);

    public class Downloader
    {
        public event DownloadEventHandler Downing;

        public void DoDownload()
        {
            double total = 10000;
            double already = 0;
            Random rnd = new Random();
            while (already<total)
            {
                System.Threading.Thread.Sleep(500);
                already += (rnd.NextDouble() / 4) * total;
                if (already > total) already = total;

                if(Downing!=null)
                {
                    DownloadEventArgs args = new DownloadEventArgs();
                    args.Percent = already / total;
                    Downing(this, args);
                }
            }

        }
    }
   public class UseDownloader
    {
        static void Main()
        {
            var downloader = new Downloader();
            downloader.Downing += ShowProgress;
            downloader.DoDownload();
        }
        static void ShowProgress(object sender ,DownloadEventArgs e)
        {
            Console.WriteLine($"Downloading . . . {e.Percent:##.#%}");
        }
    }
}
