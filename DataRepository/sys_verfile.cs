namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_verfile
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string systemname { get; set; }

        [Required]
        [StringLength(20)]
        public string version { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string filename { get; set; }

        [Required]
        [StringLength(40)]
        public string filepath { get; set; }

        public int? filesize { get; set; }

        public int? way { get; set; }

        public int? zip { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int filebodyid { get; set; }

        [Column(TypeName = "image")]
        public byte[] filebody { get; set; }

        [StringLength(1)]
        public string is_branch_file { get; set; }
    }
}
