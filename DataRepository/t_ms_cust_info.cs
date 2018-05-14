namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_ms_cust_info
    {
        [Required]
        [StringLength(4)]
        public string group_no { get; set; }

        [Key]
        [StringLength(20)]
        public string cust_no { get; set; }

        [StringLength(20)]
        public string cust_name { get; set; }

        [StringLength(24)]
        public string mobile { get; set; }

        [StringLength(2)]
        public string sex { get; set; }

        [StringLength(50)]
        public string addr { get; set; }

        [StringLength(10)]
        public string zip { get; set; }

        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(40)]
        public string e_mail { get; set; }

        public DateTime? birthday { get; set; }

        [StringLength(50)]
        public string company { get; set; }

        [StringLength(20)]
        public string duty { get; set; }

        [StringLength(20)]
        public string region { get; set; }

        [StringLength(20)]
        public string id_card { get; set; }

        [StringLength(20)]
        public string cust_type { get; set; }

        public DateTime? begin_date { get; set; }

        public DateTime? end_date { get; set; }

        [StringLength(100)]
        public string memo { get; set; }
    }
}
