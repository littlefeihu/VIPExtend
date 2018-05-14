namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_check_init
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        public DateTime? oper_date { get; set; }

        [Required]
        [StringLength(1)]
        public string oper_range { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(256)]
        public string check_cls { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(6)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        public int? print_num { get; set; }

        [StringLength(255)]
        public string other1 { get; set; }

        [StringLength(4)]
        public string proposer { get; set; }

        public int successFlag { get; set; }
    }
}
