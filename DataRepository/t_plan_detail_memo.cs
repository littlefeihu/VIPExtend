namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_plan_detail_memo
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal plan_id { get; set; }

        [StringLength(20)]
        public string plan_no { get; set; }

        [StringLength(20)]
        public string plan_code { get; set; }

        [StringLength(10)]
        public string plan_num_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? plan_discount_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? plan_sen_amt { get; set; }
    }
}
