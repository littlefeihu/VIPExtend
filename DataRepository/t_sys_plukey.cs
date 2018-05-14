namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_plukey
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string item_no { get; set; }

        [StringLength(1)]
        public string plu_key { get; set; }

        [StringLength(50)]
        public string memo { get; set; }
    }
}
