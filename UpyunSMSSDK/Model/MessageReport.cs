using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    public class MessageReport
    {
        public DateTime? from { get; set; }
        public DateTime? to { get; set; }
        public string mobile { get; set; }
        public string status { get; set; }
        public string page { get; set; }
        public string per_page { get; set; }

        public string GetURLParam() {
            var param = "";
            if (this.from.HasValue)
            {
                param += "from=" + this.from.Value;
            }
            if (this.to.HasValue)
            {
                param += "to=" + this.to.Value;
            }
            if (!string.IsNullOrWhiteSpace(this.mobile))
            {
                param += "mobile=" + this.mobile;
            }
            if (!string.IsNullOrWhiteSpace(this.status))
            {
                param += "status=" + this.status;
            }
            if (!string.IsNullOrWhiteSpace(this.page))
            {
                param += "page=" + this.page;
            }
            if (!string.IsNullOrWhiteSpace(this.per_page))
            {
                param += "per_page=" + this.per_page;
            }

            return param;
        }
    }
}
