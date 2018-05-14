namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_payment_info
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string pay_way { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string pay_flag { get; set; }

        [Required]
        [StringLength(20)]
        public string pay_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? default_amt { get; set; }

        [StringLength(1)]
        public string acc_flag { get; set; }

        [StringLength(1)]
        public string jf_flag { get; set; }

        [StringLength(30)]
        public string pay_memo { get; set; }
    }
}
