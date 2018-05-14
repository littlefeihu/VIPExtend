namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_customize_report
    {
        [Key]
        [StringLength(20)]
        public string report_name { get; set; }

        [StringLength(40)]
        public string report_desc { get; set; }

        [Column(TypeName = "text")]
        public string report_code { get; set; }

        [Required]
        [StringLength(256)]
        public string report_type { get; set; }

        public DateTime? create_date { get; set; }

        [Required]
        [StringLength(4)]
        public string create_oper { get; set; }

        [StringLength(1)]
        public string shareable { get; set; }

        [StringLength(30)]
        public string memo { get; set; }
    }
}
