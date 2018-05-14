namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cw_t_select
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string trans_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string db_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string item_code { get; set; }

        [Required]
        [StringLength(16)]
        public string item_desc { get; set; }

        [StringLength(1)]
        public string select_flag { get; set; }

        [StringLength(16)]
        public string title { get; set; }

        [StringLength(20)]
        public string item_value { get; set; }

        [StringLength(1)]
        public string change_flag { get; set; }

        public int? tab_order { get; set; }
    }
}
