namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_da_saleman_daysum
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string oper_date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string sale_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? so_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? so_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_ret_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_ret_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_send_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_send_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_dct_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_rate { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_ration_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? clss_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? brand_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? duty_rate_amt { get; set; }
    }
}
