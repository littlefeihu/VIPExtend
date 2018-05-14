namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_itemlist
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(20)]
        public string card_id { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal send_qty { get; set; }

        public DateTime? begin_date { get; set; }

        public DateTime? end_date { get; set; }

        [Required]
        [StringLength(1)]
        public string draw_flag { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [Required]
        [StringLength(6)]
        public string draw_branch_no { get; set; }

        [StringLength(4)]
        public string draw_oper_id { get; set; }

        public DateTime? draw_oper_date { get; set; }
    }
}
