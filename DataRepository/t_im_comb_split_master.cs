namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_comb_split_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? price { get; set; }

        [StringLength(1)]
        public string cs_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string db_no { get; set; }

        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(4)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? valid_date { get; set; }

        [Required]
        [StringLength(4)]
        public string oper_id { get; set; }

        [StringLength(4)]
        public string dept_id { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amt { get; set; }

        [StringLength(6)]
        public string branch_flag { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        public int? print_num { get; set; }
    }
}
