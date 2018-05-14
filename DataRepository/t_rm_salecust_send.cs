namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_salecust_send
    {
        [Key]
        [StringLength(20)]
        public string flow_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(100)]
        public string cust_name { get; set; }

        [StringLength(100)]
        public string cust_man { get; set; }

        [StringLength(255)]
        public string cust_addr { get; set; }

        [StringLength(100)]
        public string cust_tel { get; set; }

        [StringLength(100)]
        public string cust_other1 { get; set; }

        [StringLength(100)]
        public string cust_other2 { get; set; }

        [StringLength(100)]
        public string cust_other3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? take_change { get; set; }

        [StringLength(12)]
        public string send_oper { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amt { get; set; }

        [StringLength(1)]
        public string pay_flag { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? real_date { get; set; }
    }
}
