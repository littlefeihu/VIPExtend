namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_reference
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string vip_type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string sys_var_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string sys_var_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(80)]
        public string sys_var_value { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string branch_no { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(60)]
        public string memo { get; set; }
    }
}
