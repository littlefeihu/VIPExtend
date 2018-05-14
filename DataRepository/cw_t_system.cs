namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cw_t_system
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string sys_cls { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(16)]
        public string sys_item { get; set; }

        [StringLength(30)]
        public string sys_value { get; set; }

        [StringLength(30)]
        public string memo { get; set; }
    }
}
