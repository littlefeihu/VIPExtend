namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_good_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string vg_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int vg_num { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal vg_vip_num { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime vg_bdate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime vg_edate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string vg_branch_no { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int vg_limit_num { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime oper_date { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string memo { get; set; }
    }
}
