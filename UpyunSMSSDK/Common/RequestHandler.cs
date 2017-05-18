using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UpyunSMSSDK.Model;

namespace UpyunSMSSDK.Common
{
    /// <summary>
    /// 请求处理
    /// </summary>
    internal class RequestHandler
    {
        private RequestParame requestParame { get; set; }

        internal RequestHandler(RequestParame requestParame)
        {
            this.requestParame = requestParame;
        }

        /// <summary>
        /// 获取返回。
        /// </summary>
        /// <returns></returns>
        internal ResponseResult GetResponse()
        {
            ResponseResult result = new ResponseResult();
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            try
            {
                if (requestParame.HttpMethod == HttpMethod.GET)
                {
                    requestParame.APIUrl += "?" + JsonConvert.SerializeObject(requestParame.Parame);
                }
                request = (HttpWebRequest)WebRequest.Create(requestParame.APIUrl);
                request.Method = requestParame.HttpMethod.ToString();
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", requestParame.Token);
                if (requestParame.HttpMethod == HttpMethod.POST)
                {
                    byte[] byteData = UTF8Encoding.UTF8.GetBytes(requestParame.Parame);
                    request.ContentLength = byteData.Length;
                    using (Stream stream = request.GetRequestStream())
                    {
                        stream.Write(byteData, 0, byteData.Length);
                    }
                }
                using (response = (HttpWebResponse)request.GetResponse())
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    result.StatusCode = response.StatusCode;
                    result.StatusDescription = response.StatusDescription;
                    result.Content = reader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                result.StatusCode = ((HttpWebResponse)e.Response).StatusCode;
                result.StatusDescription = ((HttpWebResponse)e.Response).StatusDescription;
                result.Content = new StreamReader(((HttpWebResponse)e.Response).GetResponseStream()).ReadToEnd();

            }
            finally
            {
                if (request != null)
                {
                    request.Abort();
                }
            }
            return result;
        }
    }
}
