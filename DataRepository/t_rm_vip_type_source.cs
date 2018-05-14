namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_type_source
    {
        [Key]
        [StringLength(2)]
        public string type_id { get; set; }

        [Required]
        [StringLength(30)]
        public string type_name { get; set; }

        [Required]
        [StringLength(1)]
        public string sale_way { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? discount { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime oper_date { get; set; }

        [StringLength(1)]
        public string acc_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? limit_times { get; set; }

        [StringLength(40)]
        public string card_type { get; set; }

        [StringLength(40)]
        public string ic_type { get; set; }

        [StringLength(1)]
        public string saving_flag { get; set; }

        [StringLength(60)]
        public string memo { get; set; }

        public int? price_type { get; set; }

        [StringLength(1)]
        public string item_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? update_acc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? update_amt { get; set; }
    }
}
