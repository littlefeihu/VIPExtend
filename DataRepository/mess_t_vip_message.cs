namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mess_t_vip_message
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(10)]
        public string mess_type { get; set; }

        [Required]
        [StringLength(1)]
        public string send_flag { get; set; }

        public DateTime? oper_date { get; set; }

        [Required]
        [StringLength(10)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(2)]
        public string card_type { get; set; }

        [StringLength(2)]
        public string to_card_type { get; set; }

        [StringLength(20)]
        public string father_card { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? giv_acc_num { get; set; }

        [StringLength(1)]
        public string oper_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? change_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? savelist_amt { get; set; }

        [StringLength(20)]
        public string flow_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acc_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? flow_amt { get; set; }

        [StringLength(4)]
        public string send_year { get; set; }

        [StringLength(10)]
        public string send_date { get; set; }

        [StringLength(10)]
        public string card_little { get; set; }

        [Column(TypeName = "numeric")]
        public decimal send_times { get; set; }
    }
}
