namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_ms_group_info
    {
        [Key]
        [StringLength(4)]
        public string group_no { get; set; }

        [StringLength(20)]
        public string group_name { get; set; }

        [StringLength(2)]
        public string type_flag { get; set; }

        [StringLength(100)]
        public string memo { get; set; }
    }
}
