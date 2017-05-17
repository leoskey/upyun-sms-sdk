using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    /// <summary>
    /// 短信发送返回。
    /// </summary>
    public class MessageResult
    {
        public List<MessageResultMate> message_ids { get; set; }
    }

    public class MessageResultMate
    {
        public string error_code { get; set; }

        public string message { get; set; }

        public int? message_id { get; set; }

        public string mobile { get; set; }
    }
}
