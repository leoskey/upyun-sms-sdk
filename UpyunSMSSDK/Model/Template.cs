using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpyunSMSSDK.Model
{
    public class Template
    {
        public Template(string title, string content, string tempSign, Location signLocation, Type type, ReportType reportType)
        {
            this.title = title;
            this.content = content;
            this.temp_sign = tempSign;
            this.sign_location = signLocation;
            this.type = type;
            this.report_type = reportType;
        }

        /// <summary>
        /// 模板标题(少于12个字)
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 模板内容（模版签名+模版内容+2少于350个字）
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 模版签名（3～8个字）
        /// </summary>
        public string temp_sign { get; set; }
        /// <summary>
        /// 模版签名位置 (top,bottom)
        /// </summary>
        public Location sign_location { get; set; }
        /// <summary>
        /// 模板类型 (industry, marketing)
        /// </summary>
        public Type type { get; set; }
        /// <summary>
        /// 审核类型（vip, general）
        /// </summary>
        public ReportType report_type { get; set; }

        public enum Location
        {
            top,
            bottom
        }

        public enum Type
        {
            industry,
            marketing
        }

        public enum ReportType
        {
            vip,
            general
        }
    }

}
