namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_spid_operator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int spid { get; set; }

        [StringLength(4)]
        public string oper_id { get; set; }
    }
}
