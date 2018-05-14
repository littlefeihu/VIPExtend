namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_info_weixin
    {
        [StringLength(20)]
        public string item_size { get; set; }

        [Key]
        [StringLength(20)]
        public string item_no { get; set; }

        [StringLength(40)]
        public string item_name { get; set; }

        [StringLength(20)]
        public string unit_name { get; set; }

        [StringLength(4)]
        public string unit_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [StringLength(2)]
        public string suitflag { get; set; }

        [StringLength(10)]
        public string discount { get; set; }

        [StringLength(12)]
        public string item_clsno { get; set; }

        [StringLength(50)]
        public string item_rem { get; set; }

        [StringLength(10)]
        public string curflag { get; set; }

        [MaxLength(300)]
        public byte[] picture { get; set; }

        [Required]
        [StringLength(1)]
        public string shlef_status { get; set; }

        [Required]
        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(255)]
        public string pic_name { get; set; }

        [Column(TypeName = "image")]
        public byte[] pic { get; set; }

        [StringLength(1)]
        public string pic_flag { get; set; }

        [StringLength(255)]
        public string spic_name { get; set; }

        [Column(TypeName = "image")]
        public byte[] spic { get; set; }

        [StringLength(200)]
        public string dish_desc { get; set; }
    }
}
