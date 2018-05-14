namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_pos_status_history
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string posid { get; set; }

        [StringLength(20)]
        public string posdesc { get; set; }

        [StringLength(20)]
        public string hostip { get; set; }

        [StringLength(20)]
        public string hostname { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string operdate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amount { get; set; }

        public decimal? orderqty { get; set; }

        public DateTime? lasttime { get; set; }

        [StringLength(10)]
        public string lastcashier { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string status { get; set; }

        [StringLength(20)]
        public string other { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
