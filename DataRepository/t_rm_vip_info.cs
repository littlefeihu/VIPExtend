namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_info
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [Required]
        [StringLength(20)]
        public string card_no { get; set; }

        [Required]
        [StringLength(2)]
        public string card_type { get; set; }

        [StringLength(8)]
        public string vip_name { get; set; }

        [StringLength(2)]
        public string vip_sex { get; set; }

        [StringLength(80)]
        public string vip_add { get; set; }

        [StringLength(10)]
        public string vip_zip { get; set; }

        [StringLength(20)]
        public string vip_tel { get; set; }

        [StringLength(30)]
        public string vip_email { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_tax { get; set; }

        [StringLength(1)]
        public string card_status { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime oper_date { get; set; }

        public DateTime? vip_start_date { get; set; }

        public DateTime? vip_end_date { get; set; }

        public int? use_num { get; set; }

        public DateTime? birthday { get; set; }

        [StringLength(18)]
        public string social_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? save_amt { get; set; }

        [StringLength(30)]
        public string residual_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? consum_amt { get; set; }

        public int? consum_count { get; set; }

        [StringLength(40)]
        public string company { get; set; }

        [StringLength(20)]
        public string duty { get; set; }

        [StringLength(20)]
        public string degree { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [StringLength(20)]
        public string homeplace { get; set; }

        [StringLength(20)]
        public string reg_place { get; set; }

        [StringLength(20)]
        public string live_place { get; set; }

        [StringLength(20)]
        public string marriage { get; set; }

        [StringLength(20)]
        public string salary_level { get; set; }

        [StringLength(4)]
        public string nation { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? height { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? weight { get; set; }

        [StringLength(2)]
        public string blood_type { get; set; }

        [StringLength(50)]
        public string favor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? now_acc_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_num { get; set; }

        [StringLength(20)]
        public string pass { get; set; }

        public DateTime? modify_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        [StringLength(20)]
        public string father_card { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? item_amt { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        public DateTime? sav_start_date { get; set; }

        public DateTime? sav_end_date { get; set; }

        [StringLength(20)]
        public string source_card_id { get; set; }

        [StringLength(255)]
        public string vip_add1 { get; set; }

        [StringLength(255)]
        public string vip_add2 { get; set; }

        [StringLength(40)]
        public string annex_property1 { get; set; }

        [StringLength(40)]
        public string annex_property2 { get; set; }

        [StringLength(40)]
        public string annex_property3 { get; set; }

        [StringLength(40)]
        public string annex_property4 { get; set; }

        [StringLength(40)]
        public string annex_property5 { get; set; }

        [StringLength(40)]
        public string annex_property6 { get; set; }

        [StringLength(40)]
        public string annex_property7 { get; set; }

        [StringLength(40)]
        public string annex_property8 { get; set; }

        [StringLength(40)]
        public string annex_property9 { get; set; }

        [StringLength(40)]
        public string annex_property10 { get; set; }

        [StringLength(4)]
        public string picture_type { get; set; }

        public DateTime? vip_spec_date1 { get; set; }

        public DateTime? vip_spec_date2 { get; set; }

        public DateTime? vip_spec_date3 { get; set; }

        [StringLength(10)]
        public string bth_flag { get; set; }

        [StringLength(2)]
        public string vip_credentials { get; set; }

        [StringLength(2)]
        public string vip_work { get; set; }

        [StringLength(2)]
        public string vip_intent { get; set; }

        [StringLength(255)]
        public string pur_hobbies { get; set; }

        [StringLength(255)]
        public string characteristics { get; set; }

        [StringLength(1)]
        public string vip_trade { get; set; }

        [StringLength(20)]
        public string vip_rem { get; set; }

        [StringLength(4)]
        public string oper_id_make { get; set; }

        public DateTime? oper_date_make { get; set; }

        public DateTime? oper_date_gi { get; set; }

        [StringLength(4)]
        public string oper_id_gi { get; set; }

        [StringLength(1)]
        public string is_makecard { get; set; }

        [StringLength(1)]
        public string IsAlive { get; set; }

        [Column(TypeName = "numeric")]
        public decimal send_amt { get; set; }

        public DateTime? send_start_date { get; set; }

        public DateTime? send_end_date { get; set; }

        public DateTime? saledate_one { get; set; }

        public DateTime? saledate_two { get; set; }

        public DateTime? saledate_three { get; set; }

        public DateTime? saledate_last { get; set; }

        [StringLength(4)]
        public string modify_oper_id { get; set; }

        [StringLength(60)]
        public string openid { get; set; }
    }
}
