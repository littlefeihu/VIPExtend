namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_wx_shop_info
    {
        [Key]
        [StringLength(20)]
        public string shop_no { get; set; }

        [Required]
        [StringLength(20)]
        public string province { get; set; }

        [Required]
        [StringLength(20)]
        public string city { get; set; }

        [Required]
        [StringLength(100)]
        public string shop_name { get; set; }

        [Required]
        [StringLength(255)]
        public string shop_address { get; set; }

        [Required]
        [StringLength(20)]
        public string shop_contacts { get; set; }

        [Required]
        [StringLength(20)]
        public string shop_tel { get; set; }

        [Required]
        [StringLength(20)]
        public string shop_mobile { get; set; }

        [Required]
        [StringLength(20)]
        public string shop_qq { get; set; }

        [Required]
        [StringLength(50)]
        public string shop_email { get; set; }
    }
}
