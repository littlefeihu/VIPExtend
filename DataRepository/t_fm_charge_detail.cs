namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fm_charge_detail
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_id { get; set; }

        [Required]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(2)]
        public string charge_no { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sub_amt { get; set; }

        [StringLength(50)]
        public string remark { get; set; }
    }
}
