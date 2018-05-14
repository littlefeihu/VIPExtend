namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_shd_sheet_detail
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? orgi_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? valid_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? order_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? large_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sub_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cost_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? send_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        public decimal? come_num { get; set; }

        [StringLength(255)]
        public string memo1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? del_day_num { get; set; }

        [StringLength(1)]
        public string del_time { get; set; }

        public DateTime? del_startdate { get; set; }

        public DateTime? del_enddate { get; set; }

        [StringLength(7)]
        public string del_week { get; set; }

        [StringLength(2)]
        public string del_day_one { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? del_sum_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? del_item_no { get; set; }

        [StringLength(1)]
        public string del_flag { get; set; }

        [StringLength(1)]
        public string del_subno_flag { get; set; }

        [StringLength(20)]
        public string del_subno { get; set; }

        [StringLength(4)]
        public string stop_day { get; set; }

        public DateTime? stop_date { get; set; }
    }
}
