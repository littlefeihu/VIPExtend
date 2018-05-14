namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_sheet_master_info
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
        public string title_desc { get; set; }

        [Required]
        [StringLength(40)]
        public string title_code { get; set; }

        [StringLength(40)]
        public string title_text { get; set; }

        [Required]
        [StringLength(1)]
        public string print_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string display_flag { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string headfooter_flag { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string type_flag { get; set; }

        [StringLength(512)]
        public string other_property { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string oper_id { get; set; }
    }
}
