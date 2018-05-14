namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_im_pdjin
    {
        [StringLength(20)]
        public string sheet_no { get; set; }

        [StringLength(10)]
        public string sup_no { get; set; }

        [StringLength(30)]
        public string item_no { get; set; }

        [StringLength(40)]
        public string item_name { get; set; }

        public int? item_flag { get; set; }

        [StringLength(14)]
        public string item_unit_no { get; set; }

        [StringLength(1)]
        public string check_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? check_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ref_qty { get; set; }

        [StringLength(4)]
        public string sheet_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? item_inprice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? item_saleprice { get; set; }

        [StringLength(40)]
        public string ref_sheetno { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        public DateTime? uptime { get; set; }

        [StringLength(20)]
        public string iPDANo { get; set; }

        [StringLength(256)]
        public string memo { get; set; }

        [StringLength(20)]
        public string branch_no { get; set; }

        [StringLength(15)]
        public string item_subno { get; set; }
    }
}
