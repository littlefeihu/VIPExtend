namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_visit
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal visit_id { get; set; }

        [Required]
        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(2)]
        public string visit_typeno { get; set; }

        [StringLength(20)]
        public string visit_type { get; set; }

        [StringLength(10)]
        public string visit_way { get; set; }

        [StringLength(40)]
        public string item_name { get; set; }

        [StringLength(60)]
        public string buy_emporium { get; set; }

        public DateTime? buy_date { get; set; }

        [StringLength(10)]
        public string satisfaction_degree { get; set; }

        [StringLength(1)]
        public string advice_type { get; set; }

        [StringLength(512)]
        public string visit_content { get; set; }

        [StringLength(4)]
        public string visit_oper_id { get; set; }

        public DateTime? visit_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(18)]
        public string flow_no { get; set; }

        [StringLength(2)]
        public string visit_subjectno { get; set; }

        [StringLength(255)]
        public string visit_subject { get; set; }

        [StringLength(1)]
        public string visit_status { get; set; }
    }
}
