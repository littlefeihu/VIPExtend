namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_item_refer
    {
        [Key]
        [StringLength(20)]
        public string item_no { get; set; }

        [StringLength(80)]
        public string item_name { get; set; }

        [StringLength(40)]
        public string item_supname { get; set; }

        [StringLength(18)]
        public string product_area { get; set; }

        [StringLength(4)]
        public string unit_no { get; set; }

        [StringLength(20)]
        public string item_size { get; set; }

        [StringLength(10)]
        public string zj_no { get; set; }
    }
}
