using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpyunSMSSDK.Model;
using UpyunSMSSDK.SMS;

namespace UpyunSMSSDK
{
    public class UpyunSMSClient
    {
        private SMSClient _smsClient = null;

        public UpyunSMSClient(string apiUrl, string token)
        {
            this._smsClient = new SMSClient(apiUrl, token);
        }

        public MessageResult SendCode(Message message)
        {
            return _smsClient.SendMessages(message);
        }
    }
}
