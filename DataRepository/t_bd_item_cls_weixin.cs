namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_cls_weixin
    {
        [Key]
        [StringLength(10)]
        public string item_clsno { get; set; }

        [StringLength(20)]
        public string item_clsname { get; set; }

        [Required]
        [StringLength(1)]
        public string shlef_status { get; set; }

        [Required]
        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
