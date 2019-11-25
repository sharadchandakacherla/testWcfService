using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace coldServe
{
    [ServiceContract]
    interface IColdServiceREST
    {
        //[OperationContract]
        //[WebGet(UriTemplate = "/GetData/{value}", RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        //string GetDataString(string value);
        

        [OperationContract]
        [WebGet(UriTemplate = "/GetURIDataRest", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetURIDataRest();
    }

}