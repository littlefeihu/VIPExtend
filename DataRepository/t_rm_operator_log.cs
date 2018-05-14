namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_operator_log
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_no { get; set; }

        public DateTime oper_date { get; set; }

        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [Required]
        [StringLength(4)]
        public string cashier_no { get; set; }

        [Required]
        [StringLength(3)]
        public string oper_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal money { get; set; }

        [StringLength(9)]
        public string shift { get; set; }

        [StringLength(20)]
        public string vip_id { get; set; }

        [StringLength(20)]
        public string card_no { get; set; }

        [StringLength(6)]
        public string cash_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [StringLength(1)]
        public string process { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(200)]
        public string memo { get; set; }

        [StringLength(4)]
        public string award_grant { get; set; }
    }
}
