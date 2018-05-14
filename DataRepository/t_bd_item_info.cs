namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_info
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

        [Column(TypeName = "numeric")]
        public decimal price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal base_price { get; set; }

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

        public int? po_cycle { get; set; }

        public int? so_cycle { get; set; }

        [StringLength(1)]
        public string automin_flag { get; set; }

        [StringLength(1)]
        public string en_dis { get; set; }

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

        [StringLength(1)]
        public string item_stock { get; set; }

        public DateTime? build_date { get; set; }

        public DateTime? modify_date { get; set; }

        public DateTime? stop_date { get; set; }

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

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(1)]
        public string vip_acc_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_acc_num { get; set; }

        [StringLength(1)]
        public string dpfm_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate { get; set; }

        [StringLength(10)]
        public string update_date { get; set; }

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

        [StringLength(256)]
        public string item_picture { get; set; }

        [StringLength(1)]
        public string sale_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? scheme_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_price5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? valid_days { get; set; }

        [StringLength(200)]
        public string memo { get; set; }

        [StringLength(1)]
        public string item_com { get; set; }

        [StringLength(18)]
        public string product_area { get; set; }

        [StringLength(1)]
        public string measure_flag { get; set; }

        [StringLength(1)]
        public string item_sup_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sup_rate { get; set; }

        [StringLength(4)]
        public string picture_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price4 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price6 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price7 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? base_price8 { get; set; }

        [StringLength(4)]
        public string new_oper_id { get; set; }

        [StringLength(4)]
        public string modify_oper_id { get; set; }

        [StringLength(1)]
        public string en_gift { get; set; }

        [StringLength(1)]
        public string promote_flag { get; set; }

        [StringLength(1)]
        public string allow_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string hand_flag { get; set; }

        [StringLength(4)]
        public string item_usage { get; set; }

        public byte? used_days { get; set; }

        public byte? visit_num { get; set; }

        [StringLength(255)]
        public string visit_interval { get; set; }

        [StringLength(1)]
        public string milk_flag { get; set; }

        [StringLength(1)]
        public string dpfm_type_orderman { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate_orderman { get; set; }
    }
}
