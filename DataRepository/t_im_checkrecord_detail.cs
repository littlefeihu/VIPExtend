namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_checkrecord_detail
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? c_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? f_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? m_qty { get; set; }
    }
}
