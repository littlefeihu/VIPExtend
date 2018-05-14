namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_updown_rdlfile
    {
        [Key]
        public int file_id { get; set; }

        [Required]
        [StringLength(50)]
        public string file_customername { get; set; }

        [Required]
        [StringLength(10)]
        public string oper_id { get; set; }

        public DateTime upload_date { get; set; }

        public DateTime? modi_date { get; set; }

        [StringLength(10)]
        public string modi_id { get; set; }

        [Required]
        [StringLength(50)]
        public string file_basename { get; set; }

        [StringLength(200)]
        public string file_memo { get; set; }

        [Required]
        [StringLength(50)]
        public string file_name { get; set; }

        [Column(TypeName = "image")]
        public byte[] file_SourceContent { get; set; }
    }
}
