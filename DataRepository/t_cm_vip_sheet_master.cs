namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_cm_vip_sheet_master
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(1)]
        public string db_no { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        [StringLength(3)]
        public string pay_way { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? discount { get; set; }

        [StringLength(3)]
        public string coin_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? paid_amt { get; set; }

        [StringLength(1)]
        public string order_status { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string order_man { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? work_date { get; set; }

        public DateTime? valid_date { get; set; }

        public DateTime? pay_date { get; set; }

        [StringLength(1)]
        public string trans_flag { get; set; }

        [StringLength(1)]
        public string acct_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_num { get; set; }

        [StringLength(6)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        public int? print_num { get; set; }

        [StringLength(4)]
        public string modified_id { get; set; }

        public DateTime? modified_date { get; set; }

        [StringLength(10)]
        public string delivery_man { get; set; }

        [StringLength(30)]
        public string card_no { get; set; }

        public DateTime? up_date { get; set; }

        [StringLength(40)]
        public string vip_name { get; set; }

        [StringLength(30)]
        public string card_id { get; set; }

        [StringLength(15)]
        public string vip_mobile { get; set; }

        [StringLength(15)]
        public string vip_tel { get; set; }

        [StringLength(50)]
        public string vip_add { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_jf { get; set; }
    }
}
