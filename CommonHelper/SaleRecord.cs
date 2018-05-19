using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public class SaleRecord
    {
        public decimal com_no { get; set; }
        public string card_no { get; set; }

        public string vip_name { get; set; }

        public string mobile { get; set; }

        public string vip_sex { get; set; }

        public DateTime? vip_start_date { get; set; }

        public DateTime? vip_end_date { get; set; }

        public DateTime? oper_date { get; set; }

        public int Differenceday
        {
            get
            {
                return DateTime.Now.Subtract(oper_date.Value).Days;
            }
        }

        public string item_brandname { get; set; }

        public string item_name { get; set; }

        public string item_no { get; set; }

        public int MaintainCount { get; set; }
        public DateTime? LastMaintainDate { get; set; }
    }
}
