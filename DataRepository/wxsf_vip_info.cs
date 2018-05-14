namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wxsf_vip_info
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string flow_no { get; set; }

        [StringLength(50)]
        public string shopid { get; set; }

        [StringLength(50)]
        public string openid { get; set; }

        [StringLength(50)]
        public string branch_no { get; set; }

        [StringLength(50)]
        public string card_id { get; set; }

        [StringLength(50)]
        public string vip_name { get; set; }

        [StringLength(50)]
        public string birthday { get; set; }

        [StringLength(50)]
        public string vip_sex { get; set; }

        [StringLength(50)]
        public string card_type { get; set; }

        [StringLength(50)]
        public string type_no { get; set; }

        [StringLength(50)]
        public string oper_date { get; set; }

        [StringLength(50)]
        public string card_status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? now_acc_num { get; set; }

        [StringLength(50)]
        public string vip_pass { get; set; }

        public DateTime? vip_start_date { get; set; }

        public DateTime? vip_end_date { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string favourableinfo { get; set; }

        [StringLength(100)]
        public string vippic { get; set; }

        [StringLength(1)]
        public string subscribe { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string oper_type { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string is_proc { get; set; }
    }
}
