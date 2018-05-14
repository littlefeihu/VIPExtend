namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sheet_print_errlog
    {
        [Key]
        [Column(Order = 0)]
        public DateTime oper_date { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(40)]
        public string computer_name { get; set; }

        [StringLength(40)]
        public string trans_no { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }
    }
}
