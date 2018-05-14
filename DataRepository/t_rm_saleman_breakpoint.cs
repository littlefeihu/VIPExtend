namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_saleman_breakpoint
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Required]
        [StringLength(4)]
        public string change_type { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(6)]
        public string sale_id { get; set; }

        public DateTime? update_date { get; set; }
    }
}
