namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_saveset
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? start_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? end_amt { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime begin_date { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime end_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? send_amt { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }
    }
}
