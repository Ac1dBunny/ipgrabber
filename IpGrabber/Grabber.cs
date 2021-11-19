using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IpGrabber
{
    class Grabber
    {
        public static string rikked()
        {
            string ip = new WebClient().DownloadString("https://ip.seeip.org/jsonip?");
            return ip;
        }
    }
}
