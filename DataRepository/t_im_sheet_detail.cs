namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_sheet_detail
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
        public decimal? order_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? large_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? orgi_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? valid_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sub_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tax { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [StringLength(255)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? come_num { get; set; }

        [StringLength(1)]
        public string in_flag { get; set; }
    }
}
