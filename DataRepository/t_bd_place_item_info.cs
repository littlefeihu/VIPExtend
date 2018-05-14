namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_place_item_info
    {
        [StringLength(10)]
        public string place_no { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }
    }
}
