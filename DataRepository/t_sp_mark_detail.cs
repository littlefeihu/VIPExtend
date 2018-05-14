namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sp_mark_detail
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(16)]
        public string sheet_no { get; set; }

        [StringLength(4)]
        public string pf_code { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pf_score { get; set; }

        [StringLength(100)]
        public string memo { get; set; }
    }
}
