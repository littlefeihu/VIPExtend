namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fm_recpay_ly_master
    {
        [StringLength(8)]
        public string sup_no { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sum_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dct_amount { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? work_date { get; set; }

        public DateTime? oper_date { get; set; }

        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        public DateTime? settle_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? notax_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tax_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? withtax_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? get_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? get_amt_sub1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? get_amt_sub2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? get_amt_sub3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sub_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        public int? print_num { get; set; }
    }
}
