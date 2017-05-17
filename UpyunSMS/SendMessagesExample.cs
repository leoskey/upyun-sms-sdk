using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UpyunSMSSDK;
using UpyunSMSSDK.Model;

namespace UpyunSMS
{
    class SendMessagesExample
    {
        static void Main(string[] args)
        {
            var sendSMSUrl = "https://sms-api.upyun.com/api/messages";
            var token = "";
           
            var message = new Message("13888888888", "81", "425344|注册");
            var client = new UpyunSMSClient(sendSMSUrl, token);
            var result = client.SendCode(message);

        }
    }
}
