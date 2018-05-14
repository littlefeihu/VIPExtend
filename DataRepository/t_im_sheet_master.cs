namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_sheet_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [Required]
        [StringLength(1)]
        public string db_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(6)]
        public string d_branch_no { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        [StringLength(3)]
        public string coin_no { get; set; }

        [StringLength(3)]
        public string pay_way { get; set; }

        public DateTime? pay_date { get; set; }

        [Required]
        [StringLength(1)]
        public string approve_flag { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? work_date { get; set; }

        [StringLength(4)]
        public string order_man { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        [StringLength(1)]
        public string trans_flag { get; set; }

        [StringLength(1)]
        public string acct_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(6)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(1)]
        public string in_flag { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        public int? print_num { get; set; }

        [StringLength(1)]
        public string other_appr_flag { get; set; }

        [StringLength(4)]
        public string other_appr_man { get; set; }

        public DateTime? other_appr_date { get; set; }

        [StringLength(1)]
        public string com_flag1 { get; set; }

        public DateTime? valid_date { get; set; }

        [StringLength(1)]
        public string order_status { get; set; }

        [StringLength(4)]
        public string modified_id { get; set; }

        public DateTime? modified_date { get; set; }

        [Required]
        [StringLength(1)]
        public string md_flag { get; set; }
    }
}
