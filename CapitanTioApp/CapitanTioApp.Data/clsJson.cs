using CapitanTioApp.Data.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace CapitanTioApp.Data
{
    public class clsJson
    {
        public async void GetJson(string feedUrl)
        {
            var webReq = (HttpWebRequest)WebRequest.Create(feedUrl);
            using (WebResponse response = await webReq.GetResponseAsync())
            {
                try 
	            {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(clsTwitterJson));
                        object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                        //result = (clsTwitterJson)objResponse;
                        conversacion.Tweets = (clsTwitterJson)objResponse;
                        List<string> chat = conversacion.getUserChat("capitantio");
	            }
	            catch (Exception)
	            {
		
		            throw;
	            }
            }
        }
    }
}
