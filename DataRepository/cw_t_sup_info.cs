namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cw_t_sup_info
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string sup_flag { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string sup_no { get; set; }

        [StringLength(10)]
        public string sup_name { get; set; }

        [StringLength(60)]
        public string to_sup { get; set; }
    }
}
