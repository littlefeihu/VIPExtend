namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_pc_price_flow_detail
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string price_type { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(8)]
        public string begin_time { get; set; }

        [StringLength(8)]
        public string end_time { get; set; }

        [StringLength(7)]
        public string week { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? discount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? buy_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? limited_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stock_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_rate { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_price2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_price2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_price3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_price3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_price4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_price4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_vip1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_vip1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_vip2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_vip2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_vip3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_vip3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_vip4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_vip4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_vip5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_vip5 { get; set; }

        [StringLength(2)]
        public string group_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_base8 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_base8 { get; set; }

        [StringLength(1)]
        public string spec_status { get; set; }

        [StringLength(4)]
        public string modified_id { get; set; }

        public DateTime? modified_date { get; set; }
    }
}
