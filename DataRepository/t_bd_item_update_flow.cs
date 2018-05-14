namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_item_update_flow
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal flow_no { get; set; }

        [StringLength(20)]
        public string old_itemno { get; set; }

        [StringLength(20)]
        public string new_itemno { get; set; }

        [StringLength(40)]
        public string item_name { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }

        [Required]
        [StringLength(1)]
        public string flag { get; set; }

        [Required]
        [StringLength(1)]
        public string type { get; set; }

        [StringLength(20)]
        public string memo { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }
    }
}
