namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_emp
    {
        [Key]
        [StringLength(6)]
        public string vch_empno { get; set; }

        [StringLength(20)]
        public string vch_empname { get; set; }

        [StringLength(2)]
        public string ch_deptno { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(12)]
        public string vch_duty { get; set; }

        [StringLength(30)]
        public string vch_tel { get; set; }

        [StringLength(2)]
        public string ch_sex { get; set; }

        public DateTime? dt_birthday { get; set; }

        [StringLength(20)]
        public string vch_id { get; set; }

        [StringLength(60)]
        public string vch_address { get; set; }

        [StringLength(60)]
        public string vch_idaddress { get; set; }

        [StringLength(40)]
        public string vch_email { get; set; }

        [StringLength(20)]
        public string contactman { get; set; }

        [StringLength(20)]
        public string contacttel { get; set; }

        [StringLength(1)]
        public string ch_state { get; set; }

        public DateTime? join_date { get; set; }

        public DateTime? dimission_date { get; set; }

        [StringLength(1)]
        public string marriage_state { get; set; }

        [StringLength(50)]
        public string favor { get; set; }

        [StringLength(60)]
        public string vch_memo { get; set; }

        [StringLength(6)]
        public string vch_operID { get; set; }

        public DateTime? dt_operdate { get; set; }

        [StringLength(1)]
        public string ch_waiterflag { get; set; }

        [StringLength(1)]
        public string ch_saleflag { get; set; }

        [StringLength(1)]
        public string ch_outflag { get; set; }

        [StringLength(1)]
        public string ch_markflag { get; set; }

        [StringLength(1)]
        public string ch_operflag { get; set; }

        [StringLength(20)]
        public string vch_handtel { get; set; }

        [StringLength(1)]
        public string ch_storeflag { get; set; }

        [StringLength(1)]
        public string ch_stockflag { get; set; }

        [StringLength(40)]
        public string health_state { get; set; }
    }
}
