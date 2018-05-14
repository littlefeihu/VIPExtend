namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_cm_rm_vip_savelist
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal flow_id { get; set; }

        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(20)]
        public string card_no { get; set; }

        [StringLength(2)]
        public string card_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string oper_type { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? ope_date { get; set; }

        [StringLength(20)]
        public string flow_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? consum_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_num { get; set; }

        [StringLength(20)]
        public string new_cardno { get; set; }

        [StringLength(60)]
        public string oper_des { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_qty { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_amt { get; set; }
    }
}
