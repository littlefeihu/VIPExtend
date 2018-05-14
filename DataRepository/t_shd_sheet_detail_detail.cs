namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_shd_sheet_detail_detail
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        [StringLength(3)]
        public string stop_day { get; set; }

        public DateTime? stop_date { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(20)]
        public string supcust_no { get; set; }

        [StringLength(30)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }
    }
}
