namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_cm_cmlog
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string com_type { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [Required]
        [StringLength(4)]
        public string com_oper { get; set; }

        [Required]
        [StringLength(1)]
        public string flag { get; set; }

        [StringLength(20)]
        public string describe { get; set; }
    }
}
