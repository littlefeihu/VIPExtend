namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_check_bak
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stock_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_price { get; set; }
    }
}
