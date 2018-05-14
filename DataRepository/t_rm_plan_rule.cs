namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_plan_rule
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string rule_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string range_flag { get; set; }

        [Required]
        [StringLength(200)]
        public string rule_describe { get; set; }

        [StringLength(100)]
        public string rule_condition { get; set; }

        [Required]
        [StringLength(100)]
        public string rule_result { get; set; }

        [Required]
        [StringLength(1)]
        public string plu_flag { get; set; }
    }
}
