namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_barcode
    {
        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Key]
        [StringLength(20)]
        public string item_barcode { get; set; }

        public DateTime? modify_date { get; set; }
    }
}
