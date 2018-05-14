namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_daysum
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
        public decimal? ret_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? giv_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ret_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? giv_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pre_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pre_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dct_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_price { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
