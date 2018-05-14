namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_plan_branch
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string plan_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string branch_no { get; set; }
    }
}
