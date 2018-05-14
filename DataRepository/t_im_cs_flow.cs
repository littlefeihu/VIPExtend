namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_cs_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(20)]
        public string sheet_no { get; set; }

        [StringLength(10)]
        public string oper_date { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(1)]
        public string trans_type { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? qty { get; set; }

        [StringLength(20)]
        public string cs_item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cs_sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cs_cost_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? cs_qty { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }

        [StringLength(20)]
        public string other3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num3 { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
