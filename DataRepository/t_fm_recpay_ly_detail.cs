namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fm_recpay_ly_detail
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ac_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sup_ly_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sup_ly_amount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }

        [Required]
        [StringLength(18)]
        public string sheet_no { get; set; }
    }
}
