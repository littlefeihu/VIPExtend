namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_visit_cls
    {
        [Key]
        [StringLength(2)]
        public string visit_typeno { get; set; }

        [StringLength(20)]
        public string visit_type { get; set; }
    }
}
