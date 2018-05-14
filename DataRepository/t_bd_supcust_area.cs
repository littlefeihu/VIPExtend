namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_supcust_area
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string supcust_clsno { get; set; }

        [Required]
        [StringLength(20)]
        public string supcust_clsname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string supcust_flag { get; set; }

        [StringLength(6)]
        public string supcust_cls_parent { get; set; }

        [StringLength(1)]
        public string supcust_display_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? supcust_comp_rate { get; set; }
    }
}
