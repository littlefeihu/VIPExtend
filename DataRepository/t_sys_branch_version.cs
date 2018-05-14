namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_branch_version
    {
        [Key]
        public int flow_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string computer_name { get; set; }

        [StringLength(20)]
        public string version { get; set; }

        public DateTime? last_login_time { get; set; }
    }
}
