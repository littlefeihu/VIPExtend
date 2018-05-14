namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_salespe_info
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string flow_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(4)]
        public string pay_way { get; set; }

        [StringLength(30)]
        public string cust_name { get; set; }

        [StringLength(18)]
        public string cust_man { get; set; }

        [StringLength(40)]
        public string cust_addr { get; set; }

        [StringLength(18)]
        public string cust_tel { get; set; }

        [StringLength(60)]
        public string cust_other1 { get; set; }

        [StringLength(60)]
        public string cust_other2 { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_amt { get; set; }

        [StringLength(1)]
        public string pay_flag { get; set; }

        [StringLength(18)]
        public string pay_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pay_amt { get; set; }

        [StringLength(6)]
        public string pay_oper { get; set; }

        public DateTime? pay_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(8)]
        public string temp_cust_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? payed_amt { get; set; }
    }
}
