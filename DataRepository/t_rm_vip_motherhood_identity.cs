namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_motherhood_identity
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(2)]
        public string baby_sex { get; set; }

        public DateTime? baby_birthday_date { get; set; }

        [StringLength(20)]
        public string brand_1 { get; set; }

        [StringLength(20)]
        public string brand_2 { get; set; }

        [StringLength(40)]
        public string motherhood_identity_1 { get; set; }

        [StringLength(40)]
        public string motherhood_identity_2 { get; set; }

        [StringLength(40)]
        public string motherhood_identity_3 { get; set; }

        [StringLength(40)]
        public string motherhood_identity_4 { get; set; }

        [StringLength(40)]
        public string motherhood_identity_5 { get; set; }

        [StringLength(20)]
        public string baby_name { get; set; }

        [StringLength(20)]
        public string baby_rem { get; set; }

        [StringLength(40)]
        public string baby_property1 { get; set; }

        [StringLength(40)]
        public string baby_property2 { get; set; }

        [StringLength(40)]
        public string baby_property3 { get; set; }

        public DateTime? yc_date { get; set; }
    }
}
