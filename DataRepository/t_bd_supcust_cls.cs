namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_supcust_cls
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string supcust_no { get; set; }

        [StringLength(1)]
        public string use_way { get; set; }

        public decimal? rate { get; set; }

        [StringLength(80)]
        public string memo { get; set; }
    }
}
