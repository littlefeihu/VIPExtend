namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        public DateTime? oper_date { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(6)]
        public string d_branch_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [Required]
        [StringLength(1)]
        public string db_no { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        [StringLength(1)]
        public string sale_way { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pre_qnty { get; set; }

        public DateTime? valid_date { get; set; }

        public DateTime? acc_date { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        public decimal? sup_ly_rate { get; set; }

        [StringLength(1)]
        public string pay_flag { get; set; }

        [StringLength(1)]
        public string sup_sale_way { get; set; }

        [StringLength(8)]
        public string sup_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_id { get; set; }

        [StringLength(1)]
        public string dpfm_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate { get; set; }

        [StringLength(20)]
        public string cls_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cls_rate { get; set; }

        [StringLength(20)]
        public string pp_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pp_rate { get; set; }

        [StringLength(4)]
        public string order_man { get; set; }

        [Required]
        [StringLength(1)]
        public string combine_sta { get; set; }

        [StringLength(20)]
        public string sheet_item { get; set; }

        [Required]
        [StringLength(1)]
        public string re_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sp_price { get; set; }

        [StringLength(18)]
        public string sp_no { get; set; }
    }
}
