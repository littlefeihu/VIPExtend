namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_order_saleflow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal com_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string flow_no { get; set; }

        [Required]
        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(20)]
        public string item_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal source_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_qnty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sale_money { get; set; }

        [StringLength(1)]
        public string sell_way { get; set; }

        [Required]
        [StringLength(6)]
        public string oper_id { get; set; }

        [StringLength(6)]
        public string sale_man { get; set; }

        [StringLength(6)]
        public string counter_no { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(1)]
        public string remote_flag { get; set; }

        [StringLength(9)]
        public string shift_no { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(10)]
        public string spec_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? pref_amt { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? in_price { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? n_stan { get; set; }

        [StringLength(20)]
        public string chr_stan { get; set; }

        [StringLength(10)]
        public string cust_no { get; set; }

        [StringLength(20)]
        public string cust_name { get; set; }

        [StringLength(50)]
        public string cust_addr { get; set; }

        [StringLength(20)]
        public string cust_tel { get; set; }

        public decimal? order_amt { get; set; }

        public DateTime? out_date { get; set; }

        [StringLength(100)]
        public string memo { get; set; }

        [StringLength(1)]
        public string other1 { get; set; }

        [StringLength(100)]
        public string other2 { get; set; }

        public int? cv_status { get; set; }
    }
}
