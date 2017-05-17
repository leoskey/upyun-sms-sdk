using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    /// <summary>
    /// 请求响应结果。
    /// </summary>
    internal class ResponseResult
    {
        /// <summary>
        /// HTTP状态。
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// HTTP状态说明。
        /// </summary>
        public string StatusDescription { get; set; }

        /// <summary>
        /// 响应体。
        /// </summary>
        public string Content { get; set; }
    }
}
