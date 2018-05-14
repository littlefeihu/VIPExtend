namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_visit_master
    {
        [Key]
        [StringLength(4)]
        public string visit_subjectno { get; set; }

        [StringLength(255)]
        public string visit_subject { get; set; }

        [StringLength(2)]
        public string visit_typeno { get; set; }
    }
}
