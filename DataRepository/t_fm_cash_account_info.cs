namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fm_cash_account_info
    {
        [Key]
        [StringLength(10)]
        public string account_no { get; set; }

        [StringLength(30)]
        public string account_name { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(100)]
        public string memo { get; set; }
    }
}
