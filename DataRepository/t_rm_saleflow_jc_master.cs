namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_saleflow_jc_master
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string flow_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? source_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? in_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? jc_qnty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? take_qnty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_money { get; set; }

        [Required]
        [StringLength(6)]
        public string oper_id { get; set; }

        [StringLength(6)]
        public string sale_man { get; set; }

        public DateTime? oper_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_rate { get; set; }

        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(20)]
        public string card_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ret_qty { get; set; }

        [StringLength(100)]
        public string memo { get; set; }
    }
}
