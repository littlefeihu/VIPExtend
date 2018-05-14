namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_attendance_spec
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string branch_no { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(10)]
        public string attd_date { get; set; }

        [StringLength(1)]
        public string spec_flag { get; set; }

        [StringLength(8)]
        public string spec_start_time { get; set; }

        [StringLength(8)]
        public string spec_end_time { get; set; }

        [StringLength(10)]
        public string spec_time { get; set; }

        [StringLength(1)]
        public string ch_auditflag { get; set; }

        [StringLength(1)]
        public string ch_saveflag { get; set; }
    }
}
