namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_accessories_identity
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(10)]
        public string novelty { get; set; }

        [StringLength(10)]
        public string service { get; set; }

        [StringLength(10)]
        public string is_speciality { get; set; }

        [StringLength(40)]
        public string accessories_identity_1 { get; set; }

        [StringLength(40)]
        public string accessories_identity_2 { get; set; }

        [StringLength(40)]
        public string accessories_identity_3 { get; set; }

        [StringLength(40)]
        public string accessories_identity_4 { get; set; }

        [StringLength(40)]
        public string accessories_identity_5 { get; set; }
    }
}
