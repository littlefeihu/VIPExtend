using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public class Vip_Acclist
    {
        public string card_no { get; set; }

        public string oper_des { get; set; }

        public decimal acc_num { get; set; }

        public DateTime? ope_date { get; set; }

    }
}
