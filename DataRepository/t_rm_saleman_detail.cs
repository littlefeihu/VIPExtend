namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_saleman_detail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string sale_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string nibs_id { get; set; }

        [StringLength(20)]
        public string memo { get; set; }
    }
}
