using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace coldServe
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class coldStart : IColdService,IColdServiceREST
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //public string GetDataString(string value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}
        public async Task<string> GetURIData()
        {
            WebClient webClient = new WebClient();
            var result = await webClient.DownloadStringTaskAsync(new Uri("https://www.google.com"));
            Thread.Sleep(15000);
            return result;
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetURIDataRest()
        {
            WebClient webClient = new WebClient();
            var result =  webClient.DownloadString(new Uri("https://www.google.com"));
            return result;
        }
    }
}
