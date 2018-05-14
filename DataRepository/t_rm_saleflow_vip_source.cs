namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_saleflow_vip_source
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Required]
        [StringLength(20)]
        public string card_id { get; set; }

        [Required]
        [StringLength(18)]
        public string flow_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Required]
        [StringLength(40)]
        public string item_name { get; set; }

        [Required]
        [StringLength(20)]
        public string item_clsno { get; set; }

        [Required]
        [StringLength(20)]
        public string item_clsname { get; set; }

        [Required]
        [StringLength(20)]
        public string item_brand { get; set; }

        [Required]
        [StringLength(20)]
        public string item_brand_name { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(30)]
        public string branch_name { get; set; }

        [Required]
        [StringLength(1)]
        public string sell_way { get; set; }

        [Column(TypeName = "numeric")]
        public decimal source_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sale_qnty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal sale_money { get; set; }

        public DateTime oper_date { get; set; }
    }
}
