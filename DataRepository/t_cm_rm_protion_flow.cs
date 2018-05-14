namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_cm_rm_protion_flow
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal com_no { get; set; }

        [StringLength(18)]
        public string flow_no { get; set; }

        public int? pro_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? source_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? send_money { get; set; }

        [StringLength(2)]
        public string special_type { get; set; }

        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(100)]
        public string pro_des { get; set; }

        [StringLength(1)]
        public string give_type { get; set; }

        [StringLength(1)]
        public string vip_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_rate { get; set; }

        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(20)]
        public string card_no { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
