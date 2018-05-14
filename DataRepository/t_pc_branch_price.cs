namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_pc_branch_price
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? scheme_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price5 { get; set; }

        [StringLength(20)]
        public string price_list { get; set; }

        [StringLength(1)]
        public string sale_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price8 { get; set; }
    }
}
