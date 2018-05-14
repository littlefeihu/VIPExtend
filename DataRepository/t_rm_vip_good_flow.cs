namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_good_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(20)]
        public string vip_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        public int? item_num { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? vip_num { get; set; }

        [StringLength(10)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
