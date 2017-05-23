using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    /// <summary>
    /// 短信发送返回。
    /// </summary>
    public class MessageResult : IResponeResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get ; set; }
        public string error_code { get; set; }
        public string message { get; set; }
        public string Content { get ; set; }
        /// <summary>
        /// 发送状态。
        /// </summary>
        public List<MessageResultMeta> message_ids { get; set; }
    }

    /// <summary>
    /// 响应成功返回数据。
    /// </summary>
    public class MessageResultMeta
    {
        public string error_code { get; set; }

        public int? message_id { get; set; }

        public string mobile { get; set; }
    }
}
