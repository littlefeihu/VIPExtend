namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_cm_fm_recpay_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        public int pay_type { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(3)]
        public string coin_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? discount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? should_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? already_amt { get; set; }

        [StringLength(18)]
        public string paid_sheetno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tax_amt { get; set; }

        [StringLength(3)]
        public string pay_way { get; set; }

        [StringLength(1)]
        public string sale_way { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pay_percent { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? acc_date { get; set; }

        public DateTime? pay_date { get; set; }

        [StringLength(1)]
        public string settle_flag { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        [StringLength(30)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string acc_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? other_amt { get; set; }
    }
}
