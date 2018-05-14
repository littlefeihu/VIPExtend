namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_batch_move
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

        [Required]
        [StringLength(18)]
        public string voucher_no { get; set; }

        [Required]
        [StringLength(10)]
        public string oper_date { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal out_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal out_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal out_amt { get; set; }

        [Required]
        [StringLength(18)]
        public string batch_no { get; set; }

        public DateTime? in_oper_date { get; set; }

        [Required]
        [StringLength(2)]
        public string in_trans_no { get; set; }

        public DateTime? acc_date { get; set; }

        public DateTime? valid_date { get; set; }

        [Required]
        [StringLength(8)]
        public string supcust_no { get; set; }

        [Required]
        [StringLength(1)]
        public string sale_way { get; set; }

        [Column(TypeName = "numeric")]
        public decimal in_price { get; set; }

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
    }
}
