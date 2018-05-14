namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_sheet_detail_info
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string main_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string template_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string dw_name { get; set; }

        [Required]
        [StringLength(40)]
        public string title_label { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string column_code { get; set; }

        [StringLength(40)]
        public string head_name { get; set; }

        [Required]
        [StringLength(50)]
        public string head_code { get; set; }

        [Required]
        [StringLength(1)]
        public string print_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string display_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal order_no { get; set; }

        [Required]
        [StringLength(1)]
        public string masterdetail_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string modify_flag { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string type_flag { get; set; }

        [StringLength(10)]
        public string x { get; set; }

        [StringLength(10)]
        public string y { get; set; }

        [StringLength(10)]
        public string width { get; set; }

        [StringLength(10)]
        public string height { get; set; }

        [StringLength(10)]
        public string color { get; set; }

        [StringLength(20)]
        public string font { get; set; }

        [StringLength(3)]
        public string fontsize { get; set; }

        [StringLength(1024)]
        public string other_property { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string oper_id { get; set; }
    }
}
