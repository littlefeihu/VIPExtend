namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_zjm
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal zjm_id { get; set; }

        [StringLength(2)]
        public string z { get; set; }

        [StringLength(1)]
        public string n { get; set; }

        [StringLength(1)]
        public string wb { get; set; }

        [StringLength(10)]
        public string bpy { get; set; }

        [StringLength(1)]
        public string ss { get; set; }

        [StringLength(1)]
        public string j1 { get; set; }

        [StringLength(1)]
        public string j2 { get; set; }

        [StringLength(1)]
        public string wbh { get; set; }
    }
}
