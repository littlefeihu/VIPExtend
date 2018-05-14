namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_batch_suspend
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        [StringLength(10)]
        public string oper_date { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [Required]
        [StringLength(255)]
        public string memo { get; set; }

        [Required]
        [StringLength(20)]
        public string other1 { get; set; }

        [Required]
        [StringLength(20)]
        public string other2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal num2 { get; set; }

        [Required]
        [StringLength(1)]
        public string com_flag { get; set; }

        [Required]
        [StringLength(14)]
        public string batch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal in_price { get; set; }

        public decimal diff_cost_price { get; set; }

        public decimal flow_no { get; set; }
    }
}
