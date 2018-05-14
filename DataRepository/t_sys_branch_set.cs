namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_branch_set
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string var_id { get; set; }

        [Required]
        [StringLength(40)]
        public string var_name { get; set; }

        [StringLength(80)]
        public string var_value { get; set; }

        [StringLength(100)]
        public string var_desc { get; set; }

        [StringLength(20)]
        public string memo { get; set; }
    }
}
