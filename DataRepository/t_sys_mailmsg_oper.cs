namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_mailmsg_oper
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal flow_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string oper_type { get; set; }
    }
}
