namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_combsplit
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string comb_item_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? item_qty { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [StringLength(1)]
        public string relation_px { get; set; }
    }
}
