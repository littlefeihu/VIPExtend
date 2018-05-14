namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_customer
    {
        [Key]
        [StringLength(40)]
        public string name { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(18)]
        public string man { get; set; }

        [StringLength(40)]
        public string address { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(18)]
        public string tel { get; set; }

        [StringLength(18)]
        public string fax { get; set; }

        [StringLength(30)]
        public string acct_back { get; set; }

        [StringLength(20)]
        public string acct_no { get; set; }

        [StringLength(20)]
        public string tax_no { get; set; }
    }
}
