using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    /// <summary>
    /// 请求发送依赖。
    /// </summary>
    internal class RequestParame
    {
        /// <summary>
        /// 请求方式。
        /// </summary>
        internal HttpMethod HttpMethod { get; set; }

        /// <summary>
        /// 请求地址。
        /// </summary>
        internal string APIUrl { get; set; }

        /// <summary>
        /// 请求参数。
        /// </summary>
        internal string Parame { get; set; }

        /// <summary>
        /// 平台Token。
        /// </summary>
        internal string Token { get; set; }

        internal RequestParame(HttpMethod httpMethod, string apiUrl, string token, string parame)
        {
            this.HttpMethod = httpMethod;
            this.APIUrl = apiUrl;
            this.Token = token;
            this.Parame = parame;
        }

    }
}
