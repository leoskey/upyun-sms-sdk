using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    public class MessageReportResult : ResponseResult
    {
        public List<MessageReportResultMeta> messages { get; set; }
        public int? total { get; set; }
    }

    public class MessageReportResultMeta
    {
        public int? id { get; set; }
        public int? template_id { get; set; }
        public string report_type { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string temp_sign { get; set; }
        public string mobile { get; set; }
        public string sent_at { get; set; }
        public DateTime? created_at { get; set; }
        public string status { get; set; }
        public int? quantity { get; set; }
        public Owner owner { get; set; }
    }

    public class Owner
    {
        public int? id { get; set; }
        public string name { get; set; }
        public int? general { get; set; }
        public int? vip { get; set; }
        public int? industry { get; set; }
        public int? marketing { get; set; }
    }
}
