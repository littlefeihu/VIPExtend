namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_tend_vip_conver_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(20)]
        public string card_id { get; set; }

        [Required]
        [StringLength(20)]
        public string card_no { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? work_date { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        [StringLength(20)]
        public string ori_item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ori_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? remain_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [Required]
        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(60)]
        public string comments { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(6)]
        public string sale_man_id { get; set; }

        public int? print_num { get; set; }

        [StringLength(10)]
        public string pay_way { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }
    }
}
