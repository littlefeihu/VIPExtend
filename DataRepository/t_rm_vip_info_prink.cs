namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_info_prink
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [Required]
        [StringLength(20)]
        public string card_no { get; set; }

        [StringLength(1)]
        public string prink_yes_no { get; set; }

        public DateTime? prink_datetime { get; set; }

        [StringLength(200)]
        public string prink_qu { get; set; }

        [StringLength(20)]
        public string prink_symptom { get; set; }

        [StringLength(1)]
        public string prink_cure { get; set; }

        [StringLength(20)]
        public string prink_bother { get; set; }

        [StringLength(20)]
        public string prink_accident { get; set; }
    }
}
