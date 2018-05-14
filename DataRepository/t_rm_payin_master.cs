namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_payin_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        public DateTime? selldate { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? payin_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string casher_id { get; set; }

        [StringLength(10)]
        public string cashier_name { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        [StringLength(4)]
        public string posid { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cheque { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ccard { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fcard { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? gcert { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? oncd { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? opay { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }

        [StringLength(20)]
        public string other3 { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [StringLength(6)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        public int? print_num { get; set; }
    }
}
