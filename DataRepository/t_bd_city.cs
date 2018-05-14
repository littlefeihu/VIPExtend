namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_city
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string province_no { get; set; }

        [Required]
        [StringLength(20)]
        public string province_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string city_no { get; set; }

        [Required]
        [StringLength(30)]
        public string city_name { get; set; }
    }
}
