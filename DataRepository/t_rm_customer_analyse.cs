namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_customer_analyse
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_no { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(14)]
        public string sheet_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amount { get; set; }

        [StringLength(2)]
        public string sex { get; set; }

        [StringLength(4)]
        public string age_leve { get; set; }

        [StringLength(60)]
        public string memo { get; set; }
    }
}
