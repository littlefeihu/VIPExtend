namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_balance_item
    {
        [Key]
        [StringLength(10)]
        public string item_code { get; set; }

        [StringLength(10)]
        public string item_name { get; set; }

        [StringLength(1)]
        public string item_type { get; set; }

        public int? output_len { get; set; }

        [StringLength(10)]
        public string default_value { get; set; }

        [StringLength(1)]
        public string output_yesno { get; set; }

        public int? output_order { get; set; }

        [StringLength(1)]
        public string output_radix_point { get; set; }

        public int? output_dec_place { get; set; }

        [StringLength(1)]
        public string split_char { get; set; }

        [StringLength(1)]
        public string fill_char { get; set; }

        [StringLength(1)]
        public string align_mode { get; set; }

        [StringLength(10)]
        public string other1 { get; set; }

        [StringLength(10)]
        public string other2 { get; set; }

        [StringLength(10)]
        public string other3 { get; set; }
    }
}
