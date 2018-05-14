namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_menu_grant
    {
        [Key]
        [StringLength(4)]
        public string func_id { get; set; }

        [StringLength(1)]
        public string grant0 { get; set; }

        [StringLength(1)]
        public string grant1 { get; set; }

        [StringLength(1)]
        public string grant2 { get; set; }

        [StringLength(1)]
        public string grant3 { get; set; }

        [StringLength(1)]
        public string grant4 { get; set; }

        [StringLength(1)]
        public string grant5 { get; set; }

        [StringLength(80)]
        public string other { get; set; }
    }
}
