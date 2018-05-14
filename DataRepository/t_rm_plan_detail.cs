namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_plan_detail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string plan_no { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal row_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string rule_para { get; set; }

        [StringLength(50)]
        public string rule_val { get; set; }
    }
}
