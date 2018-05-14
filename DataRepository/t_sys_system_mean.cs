namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_system_mean
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(20)]
        public string menu_name { get; set; }

        [StringLength(80)]
        public string control_name { get; set; }

        [StringLength(40)]
        public string control_ename { get; set; }

        [StringLength(100)]
        public string default_value { get; set; }

        [StringLength(100)]
        public string modify_value { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(10)]
        public string branch_no { get; set; }

        [StringLength(40)]
        public string other { get; set; }
    }
}
