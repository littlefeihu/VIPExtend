namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_check_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(18)]
        public string check_no { get; set; }

        [Required]
        [StringLength(2)]
        public string trans_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string oper_range { get; set; }

        [StringLength(1)]
        public string dup_process { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(256)]
        public string check_cls { get; set; }

        [StringLength(40)]
        public string meno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(6)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        public int? print_num { get; set; }

        [StringLength(40)]
        public string other1 { get; set; }
    }
}
