namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_menu_desktop
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string menu_id { get; set; }

        [StringLength(40)]
        public string menu_name { get; set; }

        [StringLength(10)]
        public string module_id { get; set; }

        [StringLength(40)]
        public string module_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string oper_id { get; set; }
    }
}
