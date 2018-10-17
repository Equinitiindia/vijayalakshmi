using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Business
{
    public class SampleData
    {
        #region "Properties"

        public Guid Id { get; set; }
        public int ApplicationId { get; set; }
        public string Type { get; set; }

        public string Summary { get; set; }
        public double Amount { get; set; }

        public DateTime PostingDate { get; set; }
        public bool IsCleared { get; set; }
        public DateTime ClearedDate { get; set; }

        #endregion
    }
}
