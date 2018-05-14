namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_discount
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string vip_type { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal acc_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_disc { get; set; }

        [StringLength(20)]
        public string memo { get; set; }
    }
}
