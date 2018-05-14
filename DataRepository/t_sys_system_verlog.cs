namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_system_verlog
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string old_database_version { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string database_version { get; set; }

        public DateTime? oper_date { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(60)]
        public string del_pc { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string del_sqlid { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string login_name { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(350)]
        public string del_program { get; set; }
    }
}
