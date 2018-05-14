namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_appitem_info
    {
        [Key]
        [StringLength(20)]
        public string item_no { get; set; }

        [Required]
        [StringLength(15)]
        public string item_subno { get; set; }

        [Required]
        [StringLength(40)]
        public string item_name { get; set; }

        [StringLength(20)]
        public string item_subname { get; set; }

        [Required]
        [StringLength(20)]
        public string item_clsno { get; set; }

        [Required]
        [StringLength(20)]
        public string item_brand { get; set; }

        [Required]
        [StringLength(20)]
        public string item_brandname { get; set; }

        [StringLength(4)]
        public string unit_no { get; set; }

        [StringLength(20)]
        public string item_size { get; set; }

        [StringLength(18)]
        public string product_area { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Required]
        [StringLength(1)]
        public string combine_sta { get; set; }

        [Required]
        [StringLength(1)]
        public string status { get; set; }

        [StringLength(1)]
        public string display_flag { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(256)]
        public string other2 { get; set; }

        [StringLength(20)]
        public string other3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num3 { get; set; }

        public int? po_cycle { get; set; }

        public int? so_cycle { get; set; }

        [StringLength(1)]
        public string automin_flag { get; set; }

        [StringLength(1)]
        public string en_dis { get; set; }

        [StringLength(1)]
        public string direct { get; set; }

        [StringLength(1)]
        public string change_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purchase_tax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_tax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? purchase_spec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? shipment_spec { get; set; }

        [StringLength(20)]
        public string item_supcust { get; set; }

        [StringLength(8)]
        public string main_supcust { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? lose_rate { get; set; }

        [StringLength(1)]
        public string item_sup_flag { get; set; }

        [StringLength(1)]
        public string item_stock { get; set; }

        [StringLength(20)]
        public string item_counter { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sup_ly_rate { get; set; }

        public DateTime? build_date { get; set; }

        public DateTime? modify_date { get; set; }

        public DateTime? stop_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate { get; set; }

        [StringLength(1)]
        public string abc { get; set; }

        [StringLength(1)]
        public string branch_price { get; set; }

        [StringLength(10)]
        public string item_rem { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_min_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price3 { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string cost_compute { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(1)]
        public string vip_acc_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_acc_num { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(6)]
        public string pro_code1 { get; set; }

        [StringLength(6)]
        public string pro_code2 { get; set; }

        [StringLength(6)]
        public string pro_code3 { get; set; }

        [StringLength(6)]
        public string pro_code4 { get; set; }

        [StringLength(6)]
        public string pro_code5 { get; set; }

        [StringLength(6)]
        public string pro_code6 { get; set; }

        [StringLength(1)]
        public string en_gift { get; set; }

        [StringLength(6)]
        public string app_branch_no { get; set; }

        public decimal? vip_price2 { get; set; }

        public decimal? vip_price3 { get; set; }

        public decimal? vip_price4 { get; set; }

        public decimal? vip_price5 { get; set; }
    }
}
