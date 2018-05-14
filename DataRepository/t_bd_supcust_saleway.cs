namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_bd_supcust_saleway
    {
        [Key]
        [StringLength(10)]
        public string code_id { get; set; }

        [StringLength(20)]
        public string code_name { get; set; }

        [StringLength(40)]
        public string note { get; set; }
    }
}
