namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_check_sum
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? in_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? stock_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? check_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? balance_qty { get; set; }

        [StringLength(1)]
        public string process_status { get; set; }

        [StringLength(40)]
        public string memo { get; set; }

        public DateTime? update_date { get; set; }
    }
}
