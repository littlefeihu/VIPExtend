namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_sheet_no
    {
        [Key]
        [StringLength(2)]
        public string sheet_id { get; set; }

        [StringLength(1)]
        public string trans_type { get; set; }

        [Required]
        [StringLength(20)]
        public string sheet_name { get; set; }

        [StringLength(1)]
        public string in_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_value { get; set; }

        [Required]
        [StringLength(1)]
        public string sheet_type { get; set; }

        [StringLength(5)]
        public string sheet_flag { get; set; }

        [StringLength(40)]
        public string dw_code { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [StringLength(40)]
        public string w_code { get; set; }

        [StringLength(10)]
        public string parm { get; set; }

        [Required]
        [StringLength(40)]
        public string master_dwo { get; set; }

        [Required]
        [StringLength(40)]
        public string detail_dwo { get; set; }

        [StringLength(30)]
        public string current_temp { get; set; }

        [StringLength(1)]
        public string default_price1 { get; set; }

        [StringLength(1)]
        public string default_price2 { get; set; }

        [StringLength(1)]
        public string modify_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? up_rate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dn_rate { get; set; }

        public int? print_num { get; set; }

        [StringLength(1)]
        public string change_cost { get; set; }
    }
}
