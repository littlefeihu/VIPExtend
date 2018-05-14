namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wxsf_member_save_list
    {
        [Key]
        [Column(Order = 0)]
        public long flow_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string flow_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string card_id { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string oper_type { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime oper_date { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "numeric")]
        public decimal amt { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string wx_flow_no { get; set; }

        [StringLength(50)]
        public string branch_no { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string is_proc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? receipt_amt { get; set; }
    }
}
