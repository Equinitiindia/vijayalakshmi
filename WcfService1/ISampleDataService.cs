using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Business;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISampleDataService" in both code and config file together.
    [ServiceContract]
    public interface ISampleDataService
    {
        [OperationContract]
       IList<SampleData>  GetData();
    }
}
