namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_cm_im_branch_stock_fix
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stock_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? route_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? avg_cost { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? last_inprice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? last_baseprice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal min_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal max_qty { get; set; }

        public decimal? acc_qty { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
