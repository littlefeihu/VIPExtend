namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_saleman
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string sale_id { get; set; }

        [Required]
        [StringLength(10)]
        public string sale_name { get; set; }

        [Required]
        [StringLength(4)]
        public string sale_status { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? return_rate { get; set; }

        [StringLength(4)]
        public string sale_duty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_duty_rate { get; set; }
    }
}
