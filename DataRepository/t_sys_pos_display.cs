namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_pos_display
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

        public short? disp_lines { get; set; }

        [StringLength(4)]
        public string disp_lang { get; set; }

        public short? disp_length { get; set; }

        [StringLength(30)]
        public string init_cmd { get; set; }

        [StringLength(30)]
        public string disp_cmd_10 { get; set; }

        [StringLength(30)]
        public string disp_cmd_11 { get; set; }

        [StringLength(30)]
        public string disp_cmd_12 { get; set; }

        [StringLength(30)]
        public string disp_cmd_20 { get; set; }

        [StringLength(30)]
        public string disp_cmd_21 { get; set; }

        [StringLength(30)]
        public string disp_cmd_22 { get; set; }

        public short? disp_light { get; set; }

        [StringLength(40)]
        public string disp_black { get; set; }

        [StringLength(40)]
        public string disp_price { get; set; }

        [StringLength(40)]
        public string disp_total { get; set; }

        [StringLength(40)]
        public string disp_paid { get; set; }

        [StringLength(40)]
        public string disp_chge { get; set; }

        public short? func_sound { get; set; }

        [StringLength(40)]
        public string sound_cmd1 { get; set; }

        [StringLength(40)]
        public string sound_cmd2 { get; set; }

        [StringLength(40)]
        public string sound_cmd3 { get; set; }
    }
}
