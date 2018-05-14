namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_casher_daysum_giv
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string oper_date { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string oper_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? giv_amt { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
