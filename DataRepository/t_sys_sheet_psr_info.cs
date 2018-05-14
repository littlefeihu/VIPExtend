namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_sheet_psr_info
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
        [StringLength(1)]
        public string template_flag { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string object_code { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] psr { get; set; }
    }
}
