namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_pc_branch_data
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_no { get; set; }

        [StringLength(20)]
        public string sheet_no { get; set; }

        [StringLength(10)]
        public string branch_no { get; set; }
    }
}
