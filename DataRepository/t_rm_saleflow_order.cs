namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_saleflow_order
    {
        [Key]
        public int com_no { get; set; }

        public short flow_id { get; set; }

        [Required]
        [StringLength(20)]
        public string flow_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(24)]
        public string item_no { get; set; }

        public decimal sale_qnty { get; set; }

        public decimal source_price { get; set; }

        public decimal sale_price { get; set; }

        public decimal sale_money { get; set; }

        [Required]
        [StringLength(3)]
        public string sell_way { get; set; }

        [Required]
        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime oper_date { get; set; }

        [StringLength(30)]
        public string card_id { get; set; }

        [StringLength(30)]
        public string card_no { get; set; }
    }
}
