namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_payin_detail
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(3)]
        public string pay_way { get; set; }

        public int? amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? par_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        [StringLength(4)]
        public string casher_id { get; set; }
    }
}
