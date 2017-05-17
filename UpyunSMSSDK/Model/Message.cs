using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    /// <summary>
    /// 短信发送参数。（请勿属性修改大小写）
    /// </summary>
    public class Message
    {
        public Message(string mobile,string templateId,string paras) {
            this.mobile = mobile;
            this.template_id = templateId;
            this.vars = paras;
        }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 模板编号
        /// </summary>
        public string template_id { get; set; }

        /// <summary>
        /// 短信参数
        /// </summary>
        public string vars { get; set; }
    }
}
