namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_da_saleman_deduct_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(18)]
        public string deduct_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(18)]
        public string flow_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [Required]
        [StringLength(10)]
        public string oper_date { get; set; }

        [Required]
        [StringLength(6)]
        public string sale_man { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? deduct_amt { get; set; }

        [StringLength(1)]
        public string deduct_type { get; set; }

        [StringLength(100)]
        public string memo { get; set; }
    }
}
