namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_mailmsg_log
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal flow_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal msg_id { get; set; }

        [StringLength(1)]
        public string msg_flag { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }
    }
}
