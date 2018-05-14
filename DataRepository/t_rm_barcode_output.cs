namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_barcode_output
    {
        [Key]
        [StringLength(20)]
        public string col_id { get; set; }

        [StringLength(20)]
        public string col_name { get; set; }

        public int? col_display { get; set; }

        public int? col_sort { get; set; }
    }
}
