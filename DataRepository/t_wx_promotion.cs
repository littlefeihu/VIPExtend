namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_wx_promotion
    {
        [Key]
        public int flowid { get; set; }

        public DateTime sdate { get; set; }

        public DateTime edate { get; set; }

        [StringLength(255)]
        public string descinfo { get; set; }

        [Column(TypeName = "image")]
        public byte[] pic { get; set; }

        [StringLength(1)]
        public string shelf_status { get; set; }

        [Required]
        [StringLength(50)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(50)]
        public string shop_id { get; set; }

        [StringLength(1)]
        public string pic_flag { get; set; }

        [StringLength(255)]
        public string pic_name { get; set; }

        public decimal? net_flow { get; set; }
    }
}
