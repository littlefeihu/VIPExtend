namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_cm_fm_recpay_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        [StringLength(1)]
        public string acc_type { get; set; }

        public DateTime? settle_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(1)]
        public string is_bysheet { get; set; }

        [StringLength(3)]
        public string pay_way { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        [StringLength(1)]
        public string flag_post { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        public int? print_num { get; set; }

        public DateTime? up_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? other_amt { get; set; }
    }
}
