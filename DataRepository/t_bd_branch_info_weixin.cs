namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_branch_info_weixin
    {
        [Key]
        [StringLength(10)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(30)]
        public string branch_name { get; set; }

        [Required]
        [StringLength(50)]
        public string branch_address { get; set; }

        [Required]
        [StringLength(500)]
        public string descinfo { get; set; }

        [Required]
        [StringLength(50)]
        public string Tel { get; set; }

        [Required]
        [StringLength(1)]
        public string shlef_status { get; set; }

        [StringLength(1)]
        public string branch_selltype { get; set; }

        [Required]
        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(255)]
        public string pic_name { get; set; }

        [Column(TypeName = "image")]
        public byte[] pic { get; set; }

        [StringLength(1)]
        public string pic_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal longitude { get; set; }
    }
}
