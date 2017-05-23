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

        private const string _apiUrl = "https://sms-api.upyun.com/api/";
        private string _messageUrl = _apiUrl + "messages";
        private string templateUrl = _apiUrl + "templates";

        public string _token { get; set; }

        public SMSClient(string token)
        {
            this._token = token;
        }

        /// <summary>
        /// 发送验证码短信。
        /// </summary>
        /// <returns></returns>
        public MessageResult SendMessages(Message message)
        {
            var result = new MessageResult();
            var var = JsonConvert.SerializeObject(message);
            var para = new RequestParame(HttpMethod.POST, _messageUrl, _token, var);
            var response = new RequestHandler(para).GetResponse();
            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                try
                {
                    result.message_ids = JsonConvert.DeserializeObject<List<MessageResultMeta>>(response.Content);
                }
                catch (Exception)
                {
                    try
                    {
                        result = JsonConvert.DeserializeObject<MessageResult>(response.Content);
                    }
                    catch (Exception)
                    {
                        result.message_ids = null;
                    }
                }
                result.StatusCode = response.StatusCode;
                result.StatusDescription = response.StatusDescription;
            }
            return result;
        }

        /// <summary>
        /// 获取短信报表。
        /// </summary>
        /// <param name="messageReport"></param>
        /// <returns></returns>
        public MessageReportResult GetMessgesReport(MessageReport messageReport)
        {
            var result = new MessageReportResult();
            var var = messageReport.GetURLParam();
            var para = new RequestParame(HttpMethod.GET, _messageUrl, _token, var);
            var response = new RequestHandler(para).GetResponse();
            if (!string.IsNullOrWhiteSpace(response.Content))
            {
                try
                {
                    result.messages = JsonConvert.DeserializeObject<List<MessageReportResultMeta>>(response.Content);
                }
                catch (Exception)
                {
                    try
                    {
                        result = JsonConvert.DeserializeObject<MessageReportResult>(response.Content);
                    }
                    catch (Exception)
                    {
                        result.messages = null;
                    }
                }
                result.StatusCode = response.StatusCode;
                result.StatusDescription = response.StatusDescription;
            }
            return result;
        }
    }
}
