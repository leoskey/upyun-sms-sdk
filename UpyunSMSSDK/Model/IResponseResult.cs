using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    /// <summary>
    /// 获得请求
    /// </summary>
    interface IResponeResult 
    {
        /// <summary>
        /// HTTP状态。
        /// </summary>
        HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// HTTP状态说明。
        /// </summary>
        string StatusDescription { get; set; }

        /// <summary>
        /// 原始响应体。
        /// </summary>
        string Content { get; set; }

        /// <summary>
        /// 错误代码。
        /// </summary>
        string error_code { get; set; }

        /// <summary>
        /// 错误提示信息。
        /// </summary>
        string message { get; set; }
    }
}
