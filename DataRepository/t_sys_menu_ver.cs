namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_menu_ver
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string product_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string menu_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string version_no { get; set; }

        [StringLength(50)]
        public string memo { get; set; }
    }
}
