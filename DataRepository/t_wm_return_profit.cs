namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_wm_return_profit
    {
        [Key]
        [Column(Order = 0)]
        [MaxLength(20)]
        public byte[] sheet_no { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [MaxLength(1)]
        public byte[] sheet_type { get; set; }

        [MaxLength(6)]
        public byte[] branch_no { get; set; }

        [MaxLength(8)]
        public byte[] supcust_no { get; set; }

        [MaxLength(20)]
        public byte[] return_type { get; set; }

        [MaxLength(20)]
        public byte[] code { get; set; }

        [MaxLength(40)]
        public byte[] name { get; set; }

        public DateTime? begin_date { get; set; }

        public DateTime? end_date { get; set; }

        public decimal? start_je { get; set; }

        public decimal? end_je { get; set; }

        public decimal? return_je { get; set; }

        [StringLength(40)]
        public string note { get; set; }
    }
}
