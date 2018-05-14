namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_dm_input_init
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(1)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string oper_range { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }
    }
}
