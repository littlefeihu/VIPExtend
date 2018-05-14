namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_spec_price_history
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_no { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(2)]
        public string special_type { get; set; }

        [StringLength(2)]
        public string vip_type { get; set; }

        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(100)]
        public string pro_des { get; set; }

        [StringLength(5)]
        public string sort_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? spe_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? discount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? limited_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sold_qty { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(8)]
        public string begin_time { get; set; }

        [StringLength(8)]
        public string end_time { get; set; }

        [StringLength(7)]
        public string week { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reach_val { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? add_val { get; set; }

        [StringLength(255)]
        public string gift_item { get; set; }

        [StringLength(255)]
        public string gift_qty { get; set; }

        public DateTime? modify_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(255)]
        public string gift_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reach_vip { get; set; }

        [StringLength(1)]
        public string cls_flag { get; set; }

        [StringLength(10)]
        public string cls_list { get; set; }
    }
}
