namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_plan_master
    {
        [Key]
        [StringLength(20)]
        public string plan_no { get; set; }

        [Required]
        [StringLength(50)]
        public string plan_name { get; set; }

        [Required]
        [StringLength(200)]
        public string plan_memo { get; set; }

        public DateTime begin_date { get; set; }

        public DateTime end_date { get; set; }

        [Required]
        [StringLength(7)]
        public string week { get; set; }

        [StringLength(6)]
        public string vip_type { get; set; }

        public DateTime oper_date { get; set; }

        [StringLength(6)]
        public string oper_man { get; set; }

        public DateTime? confirm_date { get; set; }

        [StringLength(6)]
        public string confirm_man { get; set; }

        public DateTime? stop_date { get; set; }

        [StringLength(6)]
        public string stop_man { get; set; }

        [Required]
        [StringLength(1)]
        public string approve_flag { get; set; }

        [Required]
        [StringLength(2)]
        public string rule_no { get; set; }

        [Required]
        [StringLength(1)]
        public string range_flag { get; set; }

        [StringLength(8)]
        public string oper_branch { get; set; }

        [StringLength(1)]
        public string multiple_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ex_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ex_amt1 { get; set; }
    }
}
