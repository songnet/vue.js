using System;
using System.Runtime.Serialization;

namespace WFKS.Check.Search.Models
{
    /// <summary>
    /// 检索请求
    /// </summary>
    [DataContract]
    public class SearchRequest
    {
        /// <summary>
        /// 论文题名
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// 论文作者
        /// </summary>
        [DataMember(Name = "author")]
        public string Author { get; set; }

        /// <summary>
        /// 论文来源
        /// </summary>
        [DataMember(Name = "source")]
        public string Source { get; set; }

        /// <summary>
        /// 论文收稿日期
        /// </summary>
        [DataMember(Name = "publishDate")]
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [DataMember(Name = "page")]
        public int Page { get; set; }

        /// <summary>
        /// 页容量
        /// </summary>
        [DataMember(Name = "pageSize")]
        public int PageSize { get; set; }
    }
}
