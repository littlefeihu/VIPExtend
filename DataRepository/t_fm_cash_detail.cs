namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fm_cash_detail
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(18)]
        public string sheet_no { get; set; }

        [StringLength(4)]
        public string fee_code { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fee_amount { get; set; }

        [StringLength(100)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
