namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_exec_info
    {
        [Key]
        [StringLength(100)]
        public string exec_name { get; set; }

        public DateTime exec_time { get; set; }
    }
}
