using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WFKS.Check.Search.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class WFPaperVM
    {
        /// <summary>
        /// 资源ID
        /// </summary>
        public int CheckinID { get; set; }

        /// <summary>
        /// 题名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 英文题名
        /// </summary>
        public string TitleE { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 年-期
        /// </summary>
        public string YearIssueText { get; set; }

        /// <summary>
        /// 中文作者
        /// </summary>
        public string CreaterInfoZ { get; set; }

        /// <summary>
        /// 英文作者
        /// </summary>
        public string CreaterInfoE { get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 期刊标示，用来构造链接
        /// </summary>
        public string f_code { get; set; }
    }
}
