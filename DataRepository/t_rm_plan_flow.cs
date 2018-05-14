namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_plan_flow
    {
        public long id { get; set; }

        [StringLength(20)]
        public string plan_no { get; set; }

        [StringLength(80)]
        public string plan_name { get; set; }

        [StringLength(80)]
        public string plan_desc { get; set; }

        [StringLength(10)]
        public string rule_no { get; set; }

        [StringLength(20)]
        public string vip_type { get; set; }

        public DateTime? begin_date { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(7)]
        public string week { get; set; }

        [StringLength(8)]
        public string begin_time { get; set; }

        [StringLength(8)]
        public string end_time { get; set; }

        public int? group_no { get; set; }

        [StringLength(20)]
        public string item_clsno { get; set; }

        [StringLength(20)]
        public string item_brandno { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [StringLength(100)]
        public string branch_no { get; set; }

        public decimal? amt { get; set; }

        public decimal? ex_amt { get; set; }

        public decimal? rate { get; set; }

        public decimal? sale_price { get; set; }

        public decimal? price { get; set; }

        public decimal? limit { get; set; }

        public decimal? limit_vip { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ex_amt1 { get; set; }
    }
}
