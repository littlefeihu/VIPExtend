namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_brand_breakpoint
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Required]
        [StringLength(1)]
        public string change_type { get; set; }

        [StringLength(20)]
        public string item_brandno { get; set; }

        public DateTime? update_date { get; set; }
    }
}
