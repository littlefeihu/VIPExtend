namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_order_bill_weixin
    {
        [Key]
        public int flow_id { get; set; }

        [StringLength(50)]
        public string sheet_no { get; set; }

        [StringLength(50)]
        public string orderman { get; set; }

        [StringLength(50)]
        public string ordertel { get; set; }

        [StringLength(50)]
        public string item_no { get; set; }

        [StringLength(50)]
        public string item_size { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        public DateTime? oper_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_qty { get; set; }

        [StringLength(50)]
        public string openid { get; set; }

        [StringLength(50)]
        public string branch_no { get; set; }

        [StringLength(50)]
        public string shopid { get; set; }

        [StringLength(1)]
        public string IsDownload { get; set; }

        [StringLength(50)]
        public string branch_name { get; set; }

        [StringLength(50)]
        public string item_name { get; set; }

        [StringLength(20)]
        public string unit_name { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(30)]
        public string type_name { get; set; }

        [StringLength(50)]
        public string ver { get; set; }

        [StringLength(50)]
        public string pay_type { get; set; }

        [StringLength(50)]
        public string deal_type { get; set; }

        [StringLength(50)]
        public string card_id { get; set; }

        [StringLength(50)]
        public string paystatus { get; set; }

        [StringLength(1)]
        public string status_upflag { get; set; }

        [StringLength(255)]
        public string memo { get; set; }
    }
}
