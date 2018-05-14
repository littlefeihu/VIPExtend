namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_shd_delivery_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        [StringLength(18)]
        public string supcust_no { get; set; }

        [StringLength(10)]
        public string branch_no { get; set; }

        [StringLength(10)]
        public string delivery_man { get; set; }

        public DateTime? delivery_date { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [StringLength(2)]
        public string del_subno_flag { get; set; }

        [StringLength(20)]
        public string del_subno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? del_day_num { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(1)]
        public string delivery_flag { get; set; }

        [StringLength(2)]
        public string del_time { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? valid_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_price { get; set; }

        [StringLength(10)]
        public string sale_oper { get; set; }

        public DateTime? sale_date { get; set; }

        [StringLength(10)]
        public string tp_oper { get; set; }

        public DateTime? tp_date { get; set; }

        [StringLength(1)]
        public string sale_flag { get; set; }

        [StringLength(1)]
        public string tp_flag { get; set; }
    }
}
