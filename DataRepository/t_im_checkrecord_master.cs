namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_checkrecord_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string shelf_no { get; set; }

        [StringLength(10)]
        public string check_id { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(200)]
        public string memo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        public int? print_num { get; set; }
    }
}
