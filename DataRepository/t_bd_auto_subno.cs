namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_auto_subno
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_clsno { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal auto_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [StringLength(20)]
        public string other1 { get; set; }

        [StringLength(20)]
        public string other2 { get; set; }
    }
}
