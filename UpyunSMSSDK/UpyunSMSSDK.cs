using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpyunSMSSDK.Model;
using UpyunSMSSDK.SMS;

namespace UpyunSMSSDK
{
    /// <summary>
    /// Upyun短信服务客户端
    /// </summary>
    public class UpyunSMSClient
    {
        private SMSClient _smsClient = null;

        /// <summary>
        /// Upyun短信服务客户端
        /// </summary>
        /// <param name="token">Token</param>
        public UpyunSMSClient(string token)
        {
            this._smsClient = new SMSClient(token);
        }

        /// <summary>
        /// 发送短信。
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public MessageResult SendMessages(Message message)
        {
            return _smsClient.SendMessages(message);
        }

        /// <summary>
        /// 获取短信报表。
        /// </summary>
        /// <param name="messageReport"></param>
        /// <returns></returns>
        public MessageReportResult GetMessagesReport(MessageReport messageReport) {
            return _smsClient.GetMessgesReport(messageReport);
        }

        /// <summary>
        /// 新增短信模板。
        /// </summary>
        /// <param name="template">短信模板参数。</param>
        /// <returns></returns>
        public TemplateResult AddTemplate(Template template) {
            return _smsClient.AddTemplate(template);
        }
    }
}
