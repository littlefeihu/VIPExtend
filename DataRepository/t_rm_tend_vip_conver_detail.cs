namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_tend_vip_conver_detail
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
        public decimal? real_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? remain_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? remain_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [StringLength(60)]
        public string comments { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? other_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? spec_price { get; set; }

        public DateTime? real_operdate { get; set; }

        public DateTime? begin_date { get; set; }
    }
}
