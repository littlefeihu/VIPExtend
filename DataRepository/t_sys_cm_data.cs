namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_cm_data
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [StringLength(50)]
        public string com_table { get; set; }

        [StringLength(1)]
        public string change_type { get; set; }

        [StringLength(30)]
        public string key1 { get; set; }

        [StringLength(30)]
        public string key2 { get; set; }

        [StringLength(30)]
        public string key3 { get; set; }

        [StringLength(30)]
        public string key4 { get; set; }

        [StringLength(30)]
        public string key5 { get; set; }

        [StringLength(30)]
        public string key6 { get; set; }

        [StringLength(30)]
        public string key7 { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(30)]
        public string branch_no { get; set; }
    }
}
