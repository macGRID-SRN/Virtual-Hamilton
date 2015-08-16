using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Charettes
{
    public static class SendData
    {
        public static string Send(string coords)
        {
            using (var client = new WebClient())
            {
                var response =
                client.UploadValues("http://45.55.176.22/opencvrezzer.php", new NameValueCollection()
                    {
                        { "pass", "VIRTUALHAMILTON" },
                        { "data", coords}
                    });

                return System.Text.Encoding.UTF8.GetString(response);
            }
        }
    }
}
