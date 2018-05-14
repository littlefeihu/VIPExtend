namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_cls
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_clsno { get; set; }

        [Required]
        [StringLength(20)]
        public string item_clsname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string item_flag { get; set; }

        [StringLength(20)]
        public string cls_parent { get; set; }

        [Required]
        [StringLength(1)]
        public string display_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal comp_rate { get; set; }

        [Required]
        [StringLength(1)]
        public string trans_flag { get; set; }
    }
}
