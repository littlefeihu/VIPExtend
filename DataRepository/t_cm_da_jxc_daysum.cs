namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_cm_da_jxc_daysum
    {
        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Required]
        [StringLength(10)]
        public string oper_date { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? init_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? init_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? init_amt2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? avg_cost_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? avg_profit_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pi_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pi_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? so_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? so_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mi_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mi_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mo_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? mo_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? di_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? di_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? do_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? do_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_ret_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_ret_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_send_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_send_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? oo_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? oo_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? settle_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? settle_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? settle_amt2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_change_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pos_dct_amt { get; set; }

        [StringLength(8)]
        public string main_sup { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? so_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(1)]
        public string item_sup_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sup_ly_rate { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }
    }
}
