namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_ms_comm_used
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string mess_title { get; set; }

        [StringLength(600)]
        public string mess_content { get; set; }

        [StringLength(20)]
        public string mess_type { get; set; }
    }
}
