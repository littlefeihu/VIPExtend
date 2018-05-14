namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_da_tran_aim
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string year_month { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? month_aim { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? month_sell { get; set; }

        [StringLength(1)]
        public string flag { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }
    }
}
