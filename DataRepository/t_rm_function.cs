namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_function
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string func_id { get; set; }

        [Required]
        [StringLength(20)]
        public string func_name { get; set; }

        [StringLength(20)]
        public string func_udname { get; set; }

        [Required]
        [StringLength(10)]
        public string pos_key { get; set; }

        [Required]
        [StringLength(1)]
        public string flag { get; set; }

        [StringLength(1)]
        public string type { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }
    }
}
