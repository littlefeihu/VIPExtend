namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_attendance_info
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(12)]
        public string branch_no { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(1)]
        public string shift_no { get; set; }

        [StringLength(10)]
        public string attd_bdate { get; set; }

        [StringLength(10)]
        public string attd_edate { get; set; }

        [StringLength(10)]
        public string pos_m_btime { get; set; }

        [StringLength(10)]
        public string pos_m_etime { get; set; }

        public DateTime? pos_m_starttime { get; set; }

        public DateTime? pos_m_endtime { get; set; }

        [StringLength(1)]
        public string spec_flag { get; set; }

        [StringLength(8)]
        public string spec_start_time { get; set; }

        [StringLength(8)]
        public string spec_end_time { get; set; }

        [StringLength(10)]
        public string spec_time { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
