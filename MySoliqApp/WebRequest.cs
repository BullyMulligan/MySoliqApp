using System.Collections.Specialized;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace MySoliqApp
{
    public class WebRequest
    {
        public void Post(string url)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["username"] = "myUser";
                data["password"] = "myPassword";
                var response = wb.UploadValues(url, "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
            }
        }

        public string Get(string url)
        {
            using (var wb = new WebClient())
            {
                
                var response = wb.DownloadString(url);
                return response;
            }
        }

        public Automatic.PsicInfo GetPsicInfoOnGet(string response)
        {
            Automatic.PsicInfo psicInfo = JsonConvert.DeserializeObject<Automatic.PsicInfo>(response);
            return psicInfo;
        }
    }
}