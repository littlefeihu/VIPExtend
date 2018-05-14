namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_pos_downfile_status
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string filename { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string posid { get; set; }

        [StringLength(1)]
        public string down_flag { get; set; }

        public DateTime? down_date { get; set; }
    }
}
