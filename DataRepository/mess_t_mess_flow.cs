namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mess_t_mess_flow
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [StringLength(20)]
        public string cust_no { get; set; }

        [StringLength(4)]
        public string group_no { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        public DateTime? send_date { get; set; }

        [StringLength(600)]
        public string mess { get; set; }

        [StringLength(1)]
        public string region { get; set; }

        public decimal? mess_id { get; set; }

        [StringLength(100)]
        public string memo { get; set; }

        [StringLength(20)]
        public string cust_name { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? plan_id { get; set; }

        [StringLength(1)]
        public string inout_type { get; set; }

        [StringLength(200)]
        public string error { get; set; }

        [StringLength(10)]
        public string branch_no { get; set; }
    }
}
