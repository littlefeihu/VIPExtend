namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_balance_branch
    {
        [StringLength(6)]
        public string flow { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string partno { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(13)]
        public string item_no { get; set; }

        [StringLength(1)]
        public string weighing { get; set; }

        [StringLength(3)]
        public string usedate { get; set; }

        [StringLength(2)]
        public string bartype { get; set; }

        [StringLength(1)]
        public string unit { get; set; }

        public decimal? tare { get; set; }

        [StringLength(1)]
        public string packtype { get; set; }

        public decimal? packweight { get; set; }

        [StringLength(2)]
        public string packerror { get; set; }

        [StringLength(10)]
        public string account { get; set; }

        [StringLength(10)]
        public string other1 { get; set; }

        [StringLength(10)]
        public string other2 { get; set; }

        [StringLength(10)]
        public string other3 { get; set; }

        [StringLength(10)]
        public string other4 { get; set; }

        [StringLength(10)]
        public string other5 { get; set; }

        [StringLength(10)]
        public string other6 { get; set; }

        [StringLength(10)]
        public string other7 { get; set; }

        [StringLength(10)]
        public string other8 { get; set; }
    }
}
