namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wxsf_order_detail
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string shopid { get; set; }

        [StringLength(50)]
        public string openid { get; set; }

        [StringLength(50)]
        public string orderno { get; set; }

        [StringLength(50)]
        public string itemno { get; set; }

        [StringLength(50)]
        public string item_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ordernum { get; set; }

        [StringLength(50)]
        public string item_unit { get; set; }

        [StringLength(50)]
        public string item_spec { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? saleprice { get; set; }
    }
}
