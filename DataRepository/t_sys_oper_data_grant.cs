namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_oper_data_grant
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string oper_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string item_no { get; set; }

        [StringLength(1)]
        public string grant_type { get; set; }
    }
}
