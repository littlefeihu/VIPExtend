namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_da_total_daysum
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string oper_date { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purchase_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pm_rise { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_rise { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_cashamt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_sumsheet { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_avgprice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_sheetrise { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? avg_profitamt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? avg_rise { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fifo_profitamt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fifo_rise { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? charge_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num9 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num10 { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
