namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_flow_sum
    {
        [Key]
        [StringLength(18)]
        public string flow_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amount { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(1)]
        public string sell_way { get; set; }

        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(20)]
        public string vip_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dis_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pay_amount { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string sale_man { get; set; }

        [StringLength(4)]
        public string cashier_no { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        [StringLength(14)]
        public string voucher_no { get; set; }

        [StringLength(9)]
        public string shift_no { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
