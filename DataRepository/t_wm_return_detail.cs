namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_wm_return_detail
    {
        [Key]
        [StringLength(20)]
        public string sheet_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        public decimal? return_je { get; set; }

        public decimal? used_je { get; set; }

        public decimal? rest_je { get; set; }

        [StringLength(40)]
        public string note { get; set; }
    }
}
