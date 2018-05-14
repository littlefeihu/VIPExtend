namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_columns
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string frm_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short table_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string oper_id { get; set; }

        [StringLength(100)]
        public string frm_name { get; set; }

        public DateTime? oper_date { get; set; }

        public int? page_size { get; set; }

        public int? def_page_size { get; set; }

        [StringLength(1000)]
        public string col_id { get; set; }

        [StringLength(200)]
        public string col_order { get; set; }

        [StringLength(1500)]
        public string col_name { get; set; }

        [StringLength(200)]
        public string col_flag { get; set; }

        [StringLength(200)]
        public string col_format { get; set; }

        [StringLength(1500)]
        public string col_defname { get; set; }

        [StringLength(1000)]
        public string col_width { get; set; }

        [StringLength(1000)]
        public string col_defwidth { get; set; }

        [StringLength(200)]
        public string col_visible { get; set; }

        [StringLength(200)]
        public string col_defvisible { get; set; }

        [StringLength(200)]
        public string col_print { get; set; }
    }
}
