namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_pc_price_flow_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(2)]
        public string vip_type { get; set; }

        public DateTime? oper_date { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        public DateTime? valid_date { get; set; }

        [StringLength(1)]
        public string valid_flag { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(8)]
        public string supcust_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(6)]
        public string branch_flag { get; set; }

        [StringLength(7)]
        public string week { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reach_val { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? add_val { get; set; }

        [StringLength(2000)]
        public string branch_list { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        public int? print_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? reach_vip { get; set; }

        [StringLength(2000)]
        public string branch_list2 { get; set; }

        [StringLength(1)]
        public string cls_flag { get; set; }

        [StringLength(10)]
        public string cls_list { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }

        [StringLength(20)]
        public string other3 { get; set; }

        [StringLength(1)]
        public string sheet_status { get; set; }

        [StringLength(4)]
        public string modified_id { get; set; }

        public DateTime? modified_date { get; set; }
    }
}
