namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_item
    {
        [Key]
        [StringLength(20)]
        public string item_no { get; set; }

        [Required]
        [StringLength(55)]
        public string memo { get; set; }

        [Required]
        [StringLength(1)]
        public string draw_status { get; set; }
    }
}
