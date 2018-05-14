namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_basecode_type
    {
        [Key]
        [StringLength(2)]
        public string type_no { get; set; }

        [Required]
        [StringLength(20)]
        public string type_name { get; set; }

        [StringLength(1)]
        public string use_flag { get; set; }
    }
}
