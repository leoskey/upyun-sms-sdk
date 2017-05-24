using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    public class TemplateResult : IResponeResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public string Content { get; set; }
        public string error_code { get; set; }
        public string message { get; set; }
        public TemplateResultMeta template { get; set; }

        public class TemplateResultMeta
        {
            public string title { get; set; }
            public string temp_sign { get; set; }
            public string content { get; set; }
            public string sign_location { get; set; }
            public string type { get; set; }
            public string status { get; set; }
            public DateTime? updated_at { get; set; }
            public string report_type { get; set; }
            public int? id { get; set; }
            public TemplateResultOwnerMeta owner { get; set; }

        }

        public class TemplateResultOwnerMeta
        {
            public int? id { get; set; }
            public string name { get; set; }
            public int? general { get; set; }
            public int? vip { get; set; }
            public int? industry { get; set; }
            public int? marketing { get; set; }
        }

    }

}
