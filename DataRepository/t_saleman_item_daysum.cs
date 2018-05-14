namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_saleman_item_daysum
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime oper_date { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string sale_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? real_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? clss_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? brand_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? duty_rate_amt { get; set; }
    }
}
