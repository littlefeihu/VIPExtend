using CommonHelper;
using DataRepository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using VIPExtend.Frms;

namespace VIPExtend
{
    public class ApplicationInstance
    {

        public static ApplicationInstance Instance = new ApplicationInstance();
        System.Timers.Timer timer1 = new System.Timers.Timer();
        private ApplicationInstance()
        {

        }

        public Form MainFrm { get; set; }

        public void Init()
        {
            var Interval = int.Parse(System.Configuration.ConfigurationManager.AppSettings["Interval"]);
            timer1.Interval = 1000 * 60 * Interval;
            timer1.Enabled = true;
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Start();
        }

        bool isRunning = false;
        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Alert();
        }

        public List<SaleRecord> alertData = new List<SaleRecord>();


        public void Alert()
        {
            if (!isRunning)
            {
                isRunning = true;



                var AlertTimes = int.Parse(System.Configuration.ConfigurationManager.AppSettings["AlertTimes"]);
                using (var db = new Model1())
                {
                    SqlParameter[] sqlParms = new SqlParameter[1];
                    sqlParms[0] = new SqlParameter("@alerttimes", AlertTimes);
                    alertData = db.Database.SqlQuery<SaleRecord>("exec QuerySaleRecrod @alerttimes", sqlParms).ToList();

                    var vipInfos = db.t_rm_vip_info.ToList();

                    foreach (var vipinfo in vipInfos)
                    {
                        var accnum = int.Parse(System.Configuration.ConfigurationManager.AppSettings["VipAccnum"]); ;
                        if (db.t_rm_vip_acclist.Any(o => o.oper_des == "活动##送积分" && o.memo == "活动##送积分" && o.acc_num == accnum && o.oper_id == "1001" && o.ope_date.Value.Month == DateTime.Now.Month && o.ope_date.Value.Year == DateTime.Now.Year))
                        {//如果这个月份已经送过积分 则跳过
                            continue;
                        }

                        vipinfo.acc_num = vipinfo.acc_num + accnum;

                        db.t_rm_vip_acclist.Add(new t_rm_vip_acclist
                        {
                            card_no = vipinfo.card_no,
                            card_id = vipinfo.card_id,
                            card_type = vipinfo.card_type,
                            branch_no = "000",
                            oper_type = "2",
                            oper_id = "1001",
                            ope_date = DateTime.Now,
                            flow_no = "",
                            consum_amt = 0,
                            acc_num = accnum,
                            oper_des = "活动##送积分",
                            memo = "活动##送积分"
                        });
                    }

                    db.SaveChanges();

                }

                if (alertData.Count > 0)
                {
                    MaintainenceAlertForm form = new MaintainenceAlertForm(alertData);
                    form.ShowDialog();
                }

                isRunning = false;
            }
        }


    }
}
