namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_pm_process_yh
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? yh_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mo_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reco_qty { get; set; }

        [StringLength(8)]
        public string sup_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ord_qty { get; set; }

        [StringLength(60)]
        public string memo { get; set; }
    }
}
