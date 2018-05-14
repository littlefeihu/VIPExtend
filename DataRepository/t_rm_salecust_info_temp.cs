namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_salecust_info_temp
    {
        [Key]
        [StringLength(8)]
        public string temp_cust_no { get; set; }

        [StringLength(30)]
        public string cust_name { get; set; }

        [StringLength(18)]
        public string cust_man { get; set; }

        [StringLength(40)]
        public string cust_addr { get; set; }

        [StringLength(18)]
        public string cust_tel { get; set; }

        [StringLength(30)]
        public string cust_other1 { get; set; }

        [StringLength(30)]
        public string cust_other2 { get; set; }

        [StringLength(30)]
        public string cust_other3 { get; set; }
    }
}
