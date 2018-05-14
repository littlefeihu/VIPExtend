namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_base_code
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string type_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string code_id { get; set; }

        [Required]
        [StringLength(30)]
        public string code_name { get; set; }

        [StringLength(30)]
        public string english_name { get; set; }

        [StringLength(20)]
        public string code_type { get; set; }

        [StringLength(50)]
        public string memo { get; set; }
    }
}
