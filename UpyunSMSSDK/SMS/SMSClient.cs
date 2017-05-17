using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpyunSMSSDK.Common;
using UpyunSMSSDK.Model;

namespace UpyunSMSSDK.SMS
{
    public class SMSClient
    {
        public string ApiUrl { get; set; }
        public string Token { get; set; }

        public SMSClient(string apiUrl, string token)
        {
            this.ApiUrl = apiUrl;
            this.Token = token;
        }

        /// <summary>
        /// 发送验证码短信。
        /// </summary>
        /// <returns></returns>
        public MessageResult SendMessages(Message message)
        {
            var result = new MessageResult();
            var vars = JsonConvert.SerializeObject(message);
            var paras = new RequestParame(HttpMethod.POST, ApiUrl, Token, vars);
            var response = new RequestHandler(paras).GetResponse();
            if (response.Content != null)
            {
                result = JsonConvert.DeserializeObject<MessageResult>(response.Content);
            }
            Console.WriteLine(DateTime.Now.ToString("【HH:mm:ss:ffff】 ") + "---- 请求内容返回 ----" + JsonConvert.SerializeObject(result));
            return result;
        }
    }
}
