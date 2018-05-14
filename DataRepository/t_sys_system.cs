namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_system
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string sys_var_id { get; set; }

        [Required]
        [StringLength(40)]
        public string sys_var_name { get; set; }

        [StringLength(255)]
        public string sys_var_value { get; set; }

        [StringLength(2)]
        public string is_changed { get; set; }

        [StringLength(100)]
        public string sys_var_desc { get; set; }

        [StringLength(1)]
        public string sys_ver_flag { get; set; }

        [StringLength(1)]
        public string sys_inited { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string branch_no { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }
    }
}
