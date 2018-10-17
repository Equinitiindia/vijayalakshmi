using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Business;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleDataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SampleDataService.svc or SampleDataService.svc.cs at the Solution Explorer and start debugging.
    public class SampleDataService : ISampleDataService
    {
        public IList<SampleData> GetData()
        {
            List<SampleData> data = new List<SampleData>();
            StreamReader sr = new StreamReader("/sampleData.json");
            string strData = string.Empty;
            using (StreamReader s = new StreamReader("/sampleData.json"))
            {
                 strData = s.ReadToEnd();
            }
            JsonTextReader js = new JsonTextReader(sr);
            JsonSerializer ser = new JsonSerializer();

            //   ser.Deserialize(js,typeof(string));
            ser.Deserialize(js);
          //  JObject jsondata = new JObject(strData);
      
           


            while (js.Read())
            {
                var s = js.ReadAsBytes();
            }

            data.Add(new SampleData
            {
                Id = new Guid("3f2b12b8-2a06-45b4-b057-45949279b4e5"),
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 58.26,
                PostingDate = Convert.ToDateTime("07/01/2016", new CultureInfo("en-US")),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("07/02/2016", new CultureInfo("en-US"))
            });

            data.Add(new SampleData
            {
                Id = new Guid("d2032222-47a6-4048-9894-11ab8ebb9f69"),
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 50.09,
                PostingDate = Convert.ToDateTime("07/01/2016", new CultureInfo("en-US")),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("07/02/2016", new CultureInfo("en-US"))
            });
            data.Add(new SampleData
            {
                Id = new Guid("d2032222-47a6-4048-9894-11ab8ebb9f69"),
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 67.09,
                PostingDate = Convert.ToDateTime("07/01/2016", new CultureInfo("en-US")),
                IsCleared = true,
                ClearedDate = Convert.ToDateTime("07/02/2016", new CultureInfo("en-US"))
            });

            return data;
        }
    }
}
