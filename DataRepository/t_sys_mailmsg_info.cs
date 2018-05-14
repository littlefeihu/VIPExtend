namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_mailmsg_info
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(6)]
        public string msg_from { get; set; }

        [StringLength(512)]
        public string msg_branch { get; set; }

        [StringLength(512)]
        public string msg_oper { get; set; }

        [Required]
        [StringLength(30)]
        public string msg_subject { get; set; }

        [StringLength(1024)]
        public string msg_detail { get; set; }

        [Required]
        [StringLength(1)]
        public string msg_type { get; set; }

        [Required]
        [StringLength(1)]
        public string msg_flag { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
