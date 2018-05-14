namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_payment_info_breakpoint
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Required]
        [StringLength(1)]
        public string change_type { get; set; }

        [StringLength(3)]
        public string pay_way { get; set; }

        [StringLength(1)]
        public string pay_flag { get; set; }

        public DateTime? update_date { get; set; }
    }
}
