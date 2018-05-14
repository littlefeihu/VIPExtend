namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_comb_split_detail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        public DateTime? valid_date { get; set; }

        [StringLength(20)]
        public string memo { get; set; }
    }
}
