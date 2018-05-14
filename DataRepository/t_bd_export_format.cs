namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_export_format
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Required]
        [StringLength(10)]
        public string mod_no { get; set; }

        [StringLength(20)]
        public string column_code { get; set; }

        [StringLength(20)]
        public string column_name { get; set; }

        public int? output_flag { get; set; }

        public int? output_width { get; set; }

        public int? output_order { get; set; }

        [StringLength(1)]
        public string default_value { get; set; }
    }
}
