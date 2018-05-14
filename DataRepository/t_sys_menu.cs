namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_menu
    {
        [Key]
        [StringLength(4)]
        public string menu_id { get; set; }

        [Required]
        [StringLength(40)]
        public string menu_name { get; set; }

        [StringLength(80)]
        public string menu_code { get; set; }

        [StringLength(4)]
        public string menu_type { get; set; }

        [StringLength(1)]
        public string open_type { get; set; }

        [StringLength(80)]
        public string open_parameter { get; set; }

        [StringLength(8)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string normal_flag { get; set; }

        [StringLength(1)]
        public string flag1 { get; set; }

        [StringLength(10)]
        public string flag2 { get; set; }

        [StringLength(1)]
        public string flag3 { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [Required]
        [StringLength(1)]
        public string net_flag { get; set; }

        [StringLength(80)]
        public string net_menu_code { get; set; }

        [StringLength(80)]
        public string net_open_parameter { get; set; }

        [StringLength(4)]
        public string net_parent_mode { get; set; }
    }
}
