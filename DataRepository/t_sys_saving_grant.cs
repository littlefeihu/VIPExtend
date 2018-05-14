namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_saving_grant
    {
        [Key]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(1)]
        public string grant_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? grant_amt { get; set; }

        public DateTime? begin_date { get; set; }

        public DateTime? end_date { get; set; }
    }
}
