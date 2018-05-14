namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_da_jxc_month_anal
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

        [Column(TypeName = "numeric")]
        public decimal? sale_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? profit_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? profit_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? velocity_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cross_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? qty_incre_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amt_incre_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? profit_incre_rate { get; set; }

        [StringLength(30)]
        public string memo { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }

        [StringLength(20)]
        public string other3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num3 { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
