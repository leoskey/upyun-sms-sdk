﻿using Newtonsoft.Json;
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
    class Example
    {
        static void Main(string[] args)
        {
            var token = "";
            var client = new UpyunSMSClient(token);

            // 发送短信。
            var message = new Message("18888888888,18888888885", "11911", "参数1|参数2");
            var messageResult = client.SendMessages(message);
            Console.WriteLine(DateTime.Now.ToString("【HH:mm:ss:ffff】 ") + "---- 请求返回 ----" + JsonConvert.SerializeObject(messageResult));

            // 获取短信报表。
            var messageReport = new MessageReport();
            var messageReportResult = client.GetMessagesReport(messageReport);
            if (messageReportResult.StatusCode == HttpStatusCode.OK && messageReportResult.error_code != null)
            {
                foreach (var item in messageReportResult.messages)
                {
                    Console.WriteLine(DateTime.Now.ToString("【HH:mm:ss:ffff】 ") + JsonConvert.SerializeObject(item));
                }
            }
            else
            {
                Console.WriteLine("参数错误，没有获得任何返回的短信报表数据。");
            }

        }
    }
}
