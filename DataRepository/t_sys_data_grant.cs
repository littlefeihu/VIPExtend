namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_data_grant
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string oper_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string item_clsno { get; set; }

        [Required]
        [StringLength(1)]
        public string data_grant { get; set; }

        [StringLength(20)]
        public string other { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string grant_type { get; set; }
    }
}
