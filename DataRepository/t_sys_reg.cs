namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_reg
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(20)]
        public string var_id { get; set; }

        [StringLength(512)]
        public string var_value { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }
    }
}
