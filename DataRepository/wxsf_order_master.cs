namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wxsf_order_master
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [StringLength(50)]
        public string shopid { get; set; }

        [StringLength(50)]
        public string openid { get; set; }

        [StringLength(50)]
        public string orderno { get; set; }

        [StringLength(50)]
        public string orderman { get; set; }

        [StringLength(50)]
        public string branch_no { get; set; }

        [StringLength(50)]
        public string branch_name { get; set; }

        [StringLength(50)]
        public string ordertel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tot_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total_dav { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total_express { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total { get; set; }

        [StringLength(1)]
        public string orderfrom { get; set; }

        [StringLength(1)]
        public string pay_type { get; set; }

        [StringLength(50)]
        public string deal_type { get; set; }

        public DateTime? operdate { get; set; }

        [StringLength(50)]
        public string type_name { get; set; }

        [StringLength(1)]
        public string dogflag { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [StringLength(50)]
        public string card_id { get; set; }

        [StringLength(50)]
        public string paystatus { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string is_proc { get; set; }

        [StringLength(255)]
        public string memo { get; set; }
    }
}
