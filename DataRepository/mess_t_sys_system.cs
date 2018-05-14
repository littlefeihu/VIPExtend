namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mess_t_sys_system
    {
        [Key]
        [StringLength(20)]
        public string sys_var_id { get; set; }

        [StringLength(40)]
        public string sys_var_name { get; set; }

        [StringLength(620)]
        public string sys_var_value { get; set; }
    }
}
