namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_good
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string vg_no { get; set; }

        public int? vg_num { get; set; }

        public decimal? vg_vip_num { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime vg_bdate { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime vg_edate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string vg_branch_no { get; set; }

        public int? vg_limit_num { get; set; }

        [Required]
        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
