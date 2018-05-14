namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_report
    {
        [Key]
        [StringLength(40)]
        public string report_name { get; set; }

        [Required]
        [StringLength(40)]
        public string report_code { get; set; }

        [StringLength(40)]
        public string report_module { get; set; }

        [StringLength(2)]
        public string dw_type { get; set; }

        public DateTime? modi_date { get; set; }

        [Required]
        [StringLength(10)]
        public string modi_oper { get; set; }

        [Required]
        [StringLength(1)]
        public string report_flag { get; set; }

        [StringLength(40)]
        public string detail_report { get; set; }

        [StringLength(128)]
        public string dw_col { get; set; }

        [StringLength(40)]
        public string gr_xcolumn { get; set; }

        [StringLength(40)]
        public string gr_ycolumn { get; set; }

        [StringLength(512)]
        public string query_condition { get; set; }

        [StringLength(512)]
        public string display_condition { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? query_day { get; set; }

        [StringLength(8)]
        public string compute_flag { get; set; }

        [StringLength(8)]
        public string multi_head { get; set; }

        [StringLength(20)]
        public string memo { get; set; }
    }
}
