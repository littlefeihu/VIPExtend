namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_branch_info
    {
        [Key]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(30)]
        public string branch_name { get; set; }

        [StringLength(1)]
        public string property { get; set; }

        [StringLength(16)]
        public string branch_man { get; set; }

        [StringLength(40)]
        public string address { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(40)]
        public string branch_email { get; set; }

        [StringLength(18)]
        public string branch_tel { get; set; }

        [StringLength(18)]
        public string branch_fax { get; set; }

        [Required]
        [StringLength(1)]
        public string display_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? area { get; set; }

        [StringLength(1)]
        public string trade_type { get; set; }

        [StringLength(1)]
        public string com_grant { get; set; }

        [StringLength(1)]
        public string account { get; set; }

        [StringLength(1)]
        public string com_init { get; set; }

        public DateTime? init_date { get; set; }

        [StringLength(1)]
        public string indep_bal { get; set; }

        [StringLength(6)]
        public string dc_no { get; set; }

        public DateTime? com_date_up { get; set; }

        public DateTime? com_date_down { get; set; }

        [StringLength(4)]
        public string com_oper_up { get; set; }

        [StringLength(4)]
        public string com_oper_down { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pi_limited { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price_ratio { get; set; }

        [StringLength(1)]
        public string price_option { get; set; }

        [StringLength(1)]
        public string vip_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_quota { get; set; }

        [StringLength(1)]
        public string vip_type { get; set; }

        [StringLength(1)]
        public string acc_flag { get; set; }

        [StringLength(1)]
        public string query_local_flag { get; set; }

        [StringLength(1)]
        public string operator_flag { get; set; }

        [StringLength(6)]
        public string branch_clsno { get; set; }

        [StringLength(1)]
        public string zbtg_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string version_flag { get; set; }

        [StringLength(6)]
        public string num_oper { get; set; }

        [StringLength(1)]
        public string query_self { get; set; }

        [StringLength(6)]
        public string price_reference { get; set; }

        [StringLength(1)]
        public string include_spec { get; set; }
    }
}
