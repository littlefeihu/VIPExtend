namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_operator
    {
        [Key]
        [StringLength(4)]
        public string oper_id { get; set; }

        [Required]
        [StringLength(10)]
        public string oper_name { get; set; }

        [StringLength(10)]
        public string oper_pw { get; set; }

        [StringLength(4)]
        public string oper_status { get; set; }

        [StringLength(4)]
        public string oper_type { get; set; }

        public DateTime? last_time { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? output_rate { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string data_grant { get; set; }

        [StringLength(10)]
        public string confirm_pw { get; set; }

        [StringLength(30)]
        public string cash_grant { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? limit_discount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? save_discount { get; set; }

        [StringLength(1)]
        public string contral_center { get; set; }

        [StringLength(10)]
        public string price_grant { get; set; }

        [StringLength(4)]
        public string group_id { get; set; }

        [StringLength(4)]
        public string oper_flag { get; set; }

        [StringLength(1)]
        public string charge { get; set; }

        [StringLength(1)]
        public string area_manager { get; set; }

        [StringLength(1)]
        public string grant_type { get; set; }

        [StringLength(1)]
        public string is_hide_stock { get; set; }
    }
}
