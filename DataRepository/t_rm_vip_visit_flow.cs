namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_visit_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(20)]
        public string card_id { get; set; }

        public DateTime oper_date { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string flow_no { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_qnty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_money { get; set; }

        public DateTime? visiting_date { get; set; }

        public DateTime? visited_date { get; set; }

        [StringLength(1)]
        public string visit_flag { get; set; }
    }
}
