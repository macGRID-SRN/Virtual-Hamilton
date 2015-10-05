using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SerialPlotter
{
    public static class SendData
    {
        public static bool isSending = false;
        public static string Send(string coords = "")
        {
            using (var client = new WebClient())
            {
                if (string.IsNullOrWhiteSpace(coords))
                {
                    coords = string.Join(",", GridDataObject.physicalObjects.Select(l => l.sendString));
                }
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
