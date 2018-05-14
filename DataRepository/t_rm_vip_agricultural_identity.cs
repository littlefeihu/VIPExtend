namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rm_vip_agricultural_identity
    {
        [Key]
        [StringLength(20)]
        public string card_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? acreage { get; set; }

        [StringLength(40)]
        public string crop1 { get; set; }

        [StringLength(40)]
        public string crop2 { get; set; }

        [StringLength(40)]
        public string crop3 { get; set; }

        [StringLength(40)]
        public string crop4 { get; set; }

        [StringLength(40)]
        public string crop5 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? breading { get; set; }

        [StringLength(40)]
        public string species1 { get; set; }

        [StringLength(40)]
        public string species2 { get; set; }

        [StringLength(40)]
        public string species3 { get; set; }

        [StringLength(40)]
        public string species4 { get; set; }

        [StringLength(40)]
        public string species5 { get; set; }
    }
}
