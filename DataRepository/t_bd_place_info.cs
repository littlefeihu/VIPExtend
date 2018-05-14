namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_place_info
    {
        [Key]
        [StringLength(10)]
        public string place_no { get; set; }

        [Required]
        [StringLength(20)]
        public string place_name { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(80)]
        public string place_notes { get; set; }

        [Required]
        [StringLength(1)]
        public string usable_flag { get; set; }

        [StringLength(10)]
        public string super_place_no { get; set; }
    }
}
