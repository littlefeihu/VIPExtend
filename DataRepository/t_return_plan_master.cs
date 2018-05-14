namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_return_plan_master
    {
        [Key]
        [StringLength(20)]
        public string plan_no { get; set; }

        [StringLength(30)]
        public string plan_name { get; set; }

        [StringLength(200)]
        public string plan_memo { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(6)]
        public string oper_man { get; set; }

        public DateTime? confirm_date { get; set; }

        [StringLength(6)]
        public string confirm_man { get; set; }

        public DateTime? stop_date { get; set; }

        [StringLength(6)]
        public string stop_man { get; set; }

        [StringLength(2)]
        public string approve_flag { get; set; }

        [StringLength(1)]
        public string royalty_setup { get; set; }

        [StringLength(1)]
        public string royalty_item { get; set; }

        [StringLength(1)]
        public string ret_ticket { get; set; }

        [StringLength(1)]
        public string ret_saving_card { get; set; }
    }
}
