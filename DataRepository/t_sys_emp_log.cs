namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_emp_log
    {
        [Key]
        public int int_flowID { get; set; }

        [Required]
        [StringLength(6)]
        public string vch_empno { get; set; }

        [Required]
        [StringLength(50)]
        public string vch_matter { get; set; }

        [StringLength(6)]
        public string vch_operID { get; set; }

        public DateTime? dt_operdate { get; set; }
    }
}
