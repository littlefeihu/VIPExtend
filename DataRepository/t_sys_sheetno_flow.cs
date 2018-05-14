namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_sheetno_flow
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string sheet_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string branch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? temp_value { get; set; }

        public DateTime? last_time { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }
    }
}
