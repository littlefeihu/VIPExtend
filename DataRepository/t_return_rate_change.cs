namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_return_rate_change
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string item_no { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime oper_date { get; set; }

        [StringLength(1)]
        public string old_dpfm_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_return_rate { get; set; }

        [StringLength(1)]
        public string new_dpfm_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_return_rate { get; set; }

        [StringLength(1)]
        public string old_dpfm_type_orderman { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? old_return_rate_orderman { get; set; }

        [StringLength(1)]
        public string new_dpfm_type_orderman { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? new_return_rate_orderman { get; set; }
    }
}
