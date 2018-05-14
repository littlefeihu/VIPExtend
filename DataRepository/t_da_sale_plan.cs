namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_da_sale_plan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string plan_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string plan_no { get; set; }

        [StringLength(30)]
        public string plan_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string time_type { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string plan_time { get; set; }

        public decimal? total_money { get; set; }

        public decimal? total_profit { get; set; }

        [StringLength(40)]
        public string note { get; set; }
    }
}
