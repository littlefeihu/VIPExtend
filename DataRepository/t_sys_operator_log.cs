namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_operator_log
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        public DateTime oper_date { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(20)]
        public string computer_name { get; set; }

        [StringLength(20)]
        public string trans_no { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }
    }
}
