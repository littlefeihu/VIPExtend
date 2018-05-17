using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public class SaleRecordAlert
    {
        public decimal com_no { get; set; }
        public string card_no { get; set; }
        public string vip_name { get; set; }
        public DateTime? oper_date { get; set; }
        public string item_name { get; set; }
        public string item_no { get; set; }
        public int MaintainCount { get; set; }
        public DateTime? LastMaintainDate { get; set; }
    }
}
