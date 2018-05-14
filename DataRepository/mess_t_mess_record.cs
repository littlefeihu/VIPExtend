namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mess_t_mess_record
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        public DateTime? send_time { get; set; }

        public int? send_nums { get; set; }

        [StringLength(30)]
        public string send_sup { get; set; }

        [StringLength(30)]
        public string other1 { get; set; }

        [StringLength(30)]
        public string other2 { get; set; }

        [StringLength(30)]
        public string other3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? num3 { get; set; }

        [StringLength(30)]
        public string send_user { get; set; }
    }
}
