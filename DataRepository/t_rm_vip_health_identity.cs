namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_health_identity
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(10)]
        public string health_status { get; set; }

        [StringLength(20)]
        public string now_eat_1 { get; set; }

        [StringLength(20)]
        public string now_eat_2 { get; set; }

        [StringLength(20)]
        public string now_eat_3 { get; set; }

        [StringLength(20)]
        public string before_eat_1 { get; set; }

        [StringLength(20)]
        public string before_eat_2 { get; set; }

        [StringLength(20)]
        public string before_eat_3 { get; set; }

        [StringLength(20)]
        public string like_buy_1 { get; set; }

        [StringLength(20)]
        public string like_buy_2 { get; set; }

        [StringLength(20)]
        public string like_buy_3 { get; set; }

        [StringLength(20)]
        public string forbid_eat_1 { get; set; }

        [StringLength(20)]
        public string forbid_eat_2 { get; set; }

        [StringLength(20)]
        public string forbid_eat_3 { get; set; }

        [StringLength(10)]
        public string attention { get; set; }

        [StringLength(40)]
        public string memo_1 { get; set; }

        [StringLength(40)]
        public string memo_2 { get; set; }

        [StringLength(40)]
        public string memo_3 { get; set; }

        [StringLength(40)]
        public string memo_4 { get; set; }

        [StringLength(40)]
        public string memo_5 { get; set; }
    }
}
