namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_sys_report_import
    {
        [Key]
        [StringLength(10)]
        public string im_datetime { get; set; }

        [StringLength(50)]
        public string im_dwname { get; set; }

        [StringLength(20)]
        public string im_model_id { get; set; }

        [StringLength(20)]
        public string im_model_name { get; set; }

        [StringLength(20)]
        public string im_submodel_id { get; set; }

        [StringLength(20)]
        public string im_submodel_name { get; set; }

        [StringLength(20)]
        public string im_menu_id { get; set; }

        [StringLength(20)]
        public string im_menu_name { get; set; }

        [StringLength(10)]
        public string im_flag { get; set; }

        [StringLength(10)]
        public string im_value { get; set; }
    }
}
