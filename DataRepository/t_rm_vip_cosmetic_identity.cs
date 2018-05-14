namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_cosmetic_identity
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [StringLength(1)]
        public string is_dermatosis { get; set; }

        public DateTime? dermatosis_date { get; set; }

        [StringLength(200)]
        public string dermatosis_cause { get; set; }

        [StringLength(10)]
        public string dermatosis_symptom { get; set; }

        [StringLength(1)]
        public string is_hospital { get; set; }

        [StringLength(10)]
        public string bother { get; set; }

        [StringLength(10)]
        public string attention { get; set; }

        [StringLength(40)]
        public string cosmetic_identity_1 { get; set; }

        [StringLength(40)]
        public string cosmetic_identity_2 { get; set; }

        [StringLength(40)]
        public string cosmetic_identity_3 { get; set; }

        [StringLength(40)]
        public string cosmetic_identity_4 { get; set; }

        [StringLength(40)]
        public string cosmetic_identity_5 { get; set; }
    }
}
