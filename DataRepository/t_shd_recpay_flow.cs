namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_shd_recpay_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

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

        [StringLength(3)]
        public string pay_way { get; set; }

        [StringLength(1)]
        public string sale_way { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? acc_date { get; set; }

        public DateTime? pay_date { get; set; }

        [StringLength(20)]
        public string supcust_no { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string acc_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? other_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ather_amt_f { get; set; }

        [StringLength(20)]
        public string old_voucher_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_delivery_amt { get; set; }
    }
}
