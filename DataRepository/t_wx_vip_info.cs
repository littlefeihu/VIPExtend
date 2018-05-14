namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_wx_vip_info
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(20)]
        public string card_type { get; set; }

        [Required]
        [StringLength(8)]
        public string vip_name { get; set; }

        public DateTime? birthday { get; set; }

        [StringLength(2)]
        public string vip_sex { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? vip_start_date { get; set; }

        public DateTime? vip_end_date { get; set; }

        [Required]
        [StringLength(1)]
        public string card_status { get; set; }

        [StringLength(20)]
        public string vip_pass { get; set; }

        public decimal? acc_num { get; set; }

        public decimal? dec_num { get; set; }

        [StringLength(50)]
        public string openid { get; set; }

        [Required]
        [StringLength(20)]
        public string shopid { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string deal_flag { get; set; }

        [StringLength(100)]
        public string memo { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [StringLength(30)]
        public string email { get; set; }

        [StringLength(20)]
        public string favourableinfo { get; set; }
    }
}
