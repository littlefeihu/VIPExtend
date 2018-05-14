namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_branch_group_info
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string group_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(50)]
        public string memo { get; set; }
    }
}
