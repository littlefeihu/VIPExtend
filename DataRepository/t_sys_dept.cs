namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_dept
    {
        [Key]
        [StringLength(2)]
        public string ch_deptno { get; set; }

        [StringLength(12)]
        public string vch_deptname { get; set; }
    }
}
