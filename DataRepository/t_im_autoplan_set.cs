namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_autoplan_set
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string item_clsno { get; set; }

        [StringLength(1)]
        public string monday { get; set; }

        [StringLength(1)]
        public string tuesday { get; set; }

        [StringLength(1)]
        public string wednesday { get; set; }

        [StringLength(1)]
        public string thursday { get; set; }

        [StringLength(1)]
        public string friday { get; set; }

        [StringLength(1)]
        public string saturday { get; set; }

        [StringLength(1)]
        public string sunday { get; set; }
    }
}
