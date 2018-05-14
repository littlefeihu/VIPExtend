namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_branch_area
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_clsno { get; set; }

        [Required]
        [StringLength(20)]
        public string branch_clsname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string branch_flag { get; set; }

        [StringLength(6)]
        public string branch_cls_parent { get; set; }

        [StringLength(1)]
        public string branch_display_flag { get; set; }
    }
}
