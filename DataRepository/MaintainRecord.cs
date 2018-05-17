namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaintainRecord")]
    public partial class MaintainRecord
    {
        public int ID { get; set; }

        public decimal? SallID { get; set; }

        [StringLength(50)]
        public string Saleman { get; set; }

        public int? Status { get; set; }

        [NotMapped]
        public string StatusText
        {
            get
            {
                switch (Status)
                {
                    case 0:
                        return "忽略保养";
                    case 1:
                        return "保养";
                    default:
                        return "";
                }
            }
        }

        public DateTime? MaintainDate { get; set; }
    }
}
