namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_sheet_paper_size
    {
        [Key]
        public int flow_id { get; set; }

        [Required]
        [StringLength(50)]
        public string frm_id { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [Required]
        [StringLength(50)]
        public string paper_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? paper_width { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? paper_height { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? paper_top { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? paper_left { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? paper_bottom { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? paper_right { get; set; }

        [StringLength(100)]
        public string memo { get; set; }
    }
}
