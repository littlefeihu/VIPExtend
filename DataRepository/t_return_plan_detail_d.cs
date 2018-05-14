namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_return_plan_detail_d
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal plan_id { get; set; }

        [StringLength(20)]
        public string plan_no { get; set; }

        [StringLength(1)]
        public string royalty_setup { get; set; }

        [StringLength(1)]
        public string num_flag { get; set; }

        [StringLength(1)]
        public string amount_flag { get; set; }

        [StringLength(1)]
        public string rate_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num_begin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num_end { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amount_begin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amount_end { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate_begin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate_end { get; set; }

        [StringLength(1)]
        public string royalty_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ret_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ret_amt { get; set; }
    }
}
