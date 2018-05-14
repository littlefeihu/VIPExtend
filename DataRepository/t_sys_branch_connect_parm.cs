namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_branch_connect_parm
    {
        [Key]
        [StringLength(10)]
        public string branch_no { get; set; }

        [StringLength(30)]
        public string server_name { get; set; }

        [StringLength(50)]
        public string database_name { get; set; }

        [StringLength(10)]
        public string port { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
