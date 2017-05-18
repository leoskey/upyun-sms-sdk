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
        public Message(string mobile, string templateId, string paras)
        {
            this.mobile = mobile;
            this.template_id = templateId;
            this.vars = paras;
        }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile
        {
            get
            {
                return this.Mobile;
            }
            set
            {
                this.Mobile = value.Trim();
            }
        }

        private string Mobile;

        /// <summary>
        /// 模板编号
        /// </summary>
        public string template_id
        {
            get
            {
                return this.TemplateId;
            }
            set
            {
                this.TemplateId = value.Trim();
            }
        }

        public string TemplateId;

        /// <summary>
        /// 短信参数
        /// </summary>
        public string vars
        {
            get
            {
                return this.Vars;
            }
            set
            {
                this.Vars = value.Trim();
            }
        }
        private string Vars;

        /// <summary>
        /// 验证参数。
        /// </summary>
        /// <returns></returns>
        internal bool IsVaild()
        {
            var flag = true;
            if (string.IsNullOrWhiteSpace(this.mobile) || string.IsNullOrWhiteSpace(this.template_id))
            {
                flag = false;
            }
            return flag;
        }
    }
}
