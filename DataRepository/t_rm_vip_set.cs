namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_set
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string vip_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string jf_type { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string vip_item_cls { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? low_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? high_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_amt { get; set; }

        public int? vip_num { get; set; }

        [StringLength(40)]
        public string memo { get; set; }
    }
}
