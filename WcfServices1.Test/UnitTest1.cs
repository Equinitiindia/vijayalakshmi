using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WcfServices1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SampleServices.SampleDataServiceClient client = new SampleServices.SampleDataServiceClient();
            var sampleData=client.GetData();

        }
    }
}
