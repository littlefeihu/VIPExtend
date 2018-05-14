namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_tend_vip_type
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string type_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [StringLength(40)]
        public string comments { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
