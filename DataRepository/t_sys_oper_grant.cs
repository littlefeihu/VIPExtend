namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_oper_grant
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string oper_id { get; set; }

        [Key]
        [Column(Order = 1)]
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

        [StringLength(1)]
        public string grant6 { get; set; }

        [StringLength(1)]
        public string grant7 { get; set; }

        [StringLength(1)]
        public string grant8 { get; set; }

        [StringLength(1)]
        public string grant9 { get; set; }

        [StringLength(20)]
        public string other { get; set; }
    }
}
