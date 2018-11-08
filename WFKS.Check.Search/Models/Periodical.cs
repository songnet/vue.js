namespace WFKS.Check.Search.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("期刊")]
    public partial class Periodical
    {
        [Key]
        public int CheckinID { get; set; }
        public string f_qcode { get; set; }
        public string F_Title { get; set; }
        public string F_EngTitle { get; set; }
        public string zz_xm { get; set; }
        public string zze_xm { get; set; }
        public string qk_name { get; set; }
        public string qk_engname { get; set; }
        public string f_year { get; set; }
        public string F_Volumn { get; set; }
        public string f_issue { get; set; }
        public string f_doi { get; set; }
        public Nullable<System.DateTime> 出版日期 { get; set; }
        public Nullable<System.DateTime> 收稿日期 { get; set; }
        public string 收稿日期类型 { get; set; }
        public Nullable<int> 有无版权 { get; set; }
        public string 资源类型 { get; set; }
    }
}
