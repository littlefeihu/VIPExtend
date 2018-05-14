namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_template_sheet_std
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string main_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short sheet_part { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string obj_name { get; set; }

        public int int_x { get; set; }

        public int int_y { get; set; }

        public int width { get; set; }

        public int height { get; set; }
    }
}
