namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_salecust_info
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string flow_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [Required]
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

        [Required]
        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_qty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Required]
        [StringLength(1)]
        public string sale_way { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string pay_flag { get; set; }

        [StringLength(18)]
        public string pay_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pay_amt { get; set; }

        public DateTime? pay_date { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
