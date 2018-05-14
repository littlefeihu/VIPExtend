namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_deduct_condrcd
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(18)]
        public string deduct_no { get; set; }

        public DateTime? oper_date { get; set; }

        [Required]
        [StringLength(6)]
        public string oper_id { get; set; }

        [StringLength(1)]
        public string deduct_type { get; set; }

        [StringLength(1)]
        public string deduct_priority { get; set; }

        [StringLength(1)]
        public string deduct_specitem { get; set; }

        [Required]
        [StringLength(10)]
        public string begin_date { get; set; }

        [Required]
        [StringLength(10)]
        public string end_date { get; set; }
    }
}
