namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fm_charge_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        [StringLength(1)]
        public string acc_type { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        public int? inout_flag { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(80)]
        public string memo { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        public DateTime? pay_date { get; set; }

        [StringLength(1)]
        public string is_internal { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        public int? print_num { get; set; }
    }
}
