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
            string ip = new WebClient().DownloadString("https://api.ip2loc.com/NMMpgI2QnqZW86y1R9bYTKkVi1VTGNKy/detect?include=city,capital,continent_code,continent_name,country_alpha_2,country_alpha_3,country_dialing_code,country_emoji,country_eu_member,country_name,country_subdivision,country_subdivision_id,country_zip_code,ip,ip_version,is_proxy,is_tor,location_latitude,location_longitude,proxy_type,success,time_zone");
            return ip;
        }
    }
}
