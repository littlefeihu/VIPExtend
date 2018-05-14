namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_protion_rule
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(2)]
        public string special_type { get; set; }

        [StringLength(14)]
        public string sheet_no { get; set; }

        [StringLength(100)]
        public string pro_des { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? discount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? limit_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? limit_qty { get; set; }

        [StringLength(1)]
        public string give_type { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dec_rate { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(6)]
        public string approve_id { get; set; }

        public DateTime? approve_time { get; set; }

        [StringLength(10)]
        public string modify_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(255)]
        public string item_clsno { get; set; }

        [StringLength(1)]
        public string clspp_flag { get; set; }
    }
}
