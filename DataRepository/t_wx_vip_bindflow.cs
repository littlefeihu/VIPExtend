namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_wx_vip_bindflow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(20)]
        public string card_id { get; set; }

        [Required]
        [StringLength(50)]
        public string openid { get; set; }

        [Required]
        [StringLength(20)]
        public string shopid { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(10)]
        public string bindtype { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? wx_flow_id { get; set; }
    }
}
