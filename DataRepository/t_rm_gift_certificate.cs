namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_gift_certificate
    {
        [Key]
        [StringLength(20)]
        public string giftcert_no { get; set; }

        [StringLength(1)]
        public string gift_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? gift_money { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string status { get; set; }

        public DateTime? begin_date { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(6)]
        public string send_branch { get; set; }

        [StringLength(18)]
        public string flow_no { get; set; }

        [StringLength(6)]
        public string pay_oper { get; set; }

        public DateTime? pay_date { get; set; }

        [StringLength(6)]
        public string pay_branch { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        [StringLength(255)]
        public string memo1 { get; set; }
    }
}
