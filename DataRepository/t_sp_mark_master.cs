namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sp_mark_master
    {
        [Key]
        [StringLength(16)]
        public string sheet_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(4)]
        public string order_man { get; set; }

        public DateTime? order_date { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pf_total { get; set; }

        [StringLength(100)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        public int? print_num { get; set; }
    }
}
