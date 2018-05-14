namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_supcust_info
    {
        [Key]
        [StringLength(8)]
        public string supcust_no { get; set; }

        [Required]
        [StringLength(1)]
        public string supcust_flag { get; set; }

        [Required]
        [StringLength(60)]
        public string sup_name { get; set; }

        [StringLength(8)]
        public string region_no { get; set; }

        [StringLength(4)]
        public string sup_type { get; set; }

        [StringLength(18)]
        public string sup_man { get; set; }

        [StringLength(80)]
        public string sup_addr { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(30)]
        public string sup_email { get; set; }

        [StringLength(18)]
        public string sup_tel { get; set; }

        [StringLength(18)]
        public string sup_fax { get; set; }

        [StringLength(60)]
        public string sup_acct_back { get; set; }

        [StringLength(30)]
        public string sup_acct_no { get; set; }

        [StringLength(30)]
        public string sup_tax_no { get; set; }

        [StringLength(1)]
        public string display_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string check_out_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? check_out_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? check_out_day { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? credit_amt { get; set; }

        [StringLength(20)]
        public string sub_no { get; set; }

        [StringLength(1)]
        public string pay_flag { get; set; }

        [StringLength(1)]
        public string order_flag { get; set; }

        public int? purchase_day { get; set; }

        public int? po_cycle { get; set; }

        [StringLength(1)]
        public string acc_level { get; set; }

        [StringLength(1)]
        public string reg_type { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(7)]
        public string purchase_week { get; set; }

        [StringLength(1)]
        public string sale_way { get; set; }

        [StringLength(30)]
        public string shopcard { get; set; }

        public DateTime? modify_date { get; set; }

        [StringLength(1)]
        public string settle_branch { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        public decimal discount { get; set; }

        [Required]
        [StringLength(1)]
        public string trans_flag { get; set; }

        [StringLength(20)]
        public string vip_card_id { get; set; }

        [StringLength(200)]
        public string memo { get; set; }

        [StringLength(1)]
        public string receive_management { get; set; }

        [StringLength(6)]
        public string mbranch_no { get; set; }

        [Required]
        [StringLength(1)]
        public string use_way { get; set; }
    }
}
