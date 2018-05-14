namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_pc_league_branch_price
    {
        [Key]
        [StringLength(20)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string use_way { get; set; }

        [StringLength(20)]
        public string use_no { get; set; }

        [StringLength(20)]
        public string use_name { get; set; }

        [StringLength(20)]
        public string supcust_no { get; set; }

        public decimal? app_price { get; set; }

        public DateTime? last_price { get; set; }

        public DateTime? top_price { get; set; }

        public decimal? lower_price { get; set; }

        [StringLength(40)]
        public string note { get; set; }
    }
}
