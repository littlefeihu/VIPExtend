namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_cm_breakpoint
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string com_table { get; set; }

        [StringLength(1)]
        public string is_changed { get; set; }

        [StringLength(40)]
        public string bk_sheetno { get; set; }

        [StringLength(10)]
        public string bk_date { get; set; }

        public DateTime? bk_datetime { get; set; }

        public decimal? bk_flow { get; set; }

        [StringLength(20)]
        public string bk_char { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }

        [StringLength(20)]
        public string other3 { get; set; }
    }
}
