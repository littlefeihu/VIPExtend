namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_pos_printer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int flowid { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Key]
        [StringLength(60)]
        public string dev_name { get; set; }

        public short dev_std { get; set; }

        [Required]
        [StringLength(3)]
        public string port_type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? baudrate { get; set; }

        [StringLength(1)]
        public string parity { get; set; }

        public short? databit { get; set; }

        public short? stopbit { get; set; }

        public short? flag_dtr { get; set; }

        public short? flag_rts { get; set; }

        [StringLength(1)]
        public string printer_hz { get; set; }

        public int? printer_type { get; set; }

        public int? printer_delay { get; set; }

        [StringLength(40)]
        public string printer_init { get; set; }

        [StringLength(40)]
        public string printer_big { get; set; }

        [StringLength(40)]
        public string printer_cut { get; set; }
    }
}
