namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_query_conditionEx
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string frm_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string oper_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string col_name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string col_des { get; set; }

        [Required]
        [StringLength(30)]
        public string col_type { get; set; }

        [Required]
        [StringLength(300)]
        public string col_querysql { get; set; }

        [Required]
        [StringLength(100)]
        public string table_name { get; set; }

        public byte order_no { get; set; }

        [Required]
        [StringLength(50)]
        public string memo { get; set; }
    }
}
