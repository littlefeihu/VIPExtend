namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_pos_account
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(4)]
        public string pos_no { get; set; }

        [Required]
        [StringLength(4)]
        public string cashier_id { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? hand_amt { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
