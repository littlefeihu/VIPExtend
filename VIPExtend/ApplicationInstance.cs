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
                    var ignoretxt = INIHelper.ReadString("IgnoreVIP", DirectoryManage.GetINIFullPath());


                    var ignoreList = ignoretxt.Split(',');

                    var mode = System.Configuration.ConfigurationManager.AppSettings["Mode"] == "debug";

                    if (mode)
                    {
                        MessageBox.Show("vip数量：" + vipInfos.Count.ToString());
                    }

                    foreach (var vipinfo in vipInfos)
                    {
                        try
                        {
                            //if (vipinfo.vip_start_date.HasValue && vipinfo.vip_start_date.Value.Month == DateTime.Now.Month)
                            //{//当月不反积分

                            //    if (mode)
                            //    {
                            //        MessageBox.Show("当月不反积分");
                            //    }
                            //    continue;
                            //}

                            if (db.t_rm_vip_acclist.Where(o => o.oper_des == "活动##送积分" && o.memo == "活动##送积分" && o.card_no == vipinfo.card_no).Count() > 15)
                            {
                                if (mode)
                                {
                                    MessageBox.Show("已经超过送积分次数 则跳过");
                                }
                                continue;
                            }


                            var accnum = int.Parse(System.Configuration.ConfigurationManager.AppSettings["VipAccnum"]);
                            if (db.t_rm_vip_acclist.Any(o => o.oper_des == "活动##送积分" && o.memo == "活动##送积分" && o.card_no == vipinfo.card_no))
                            {
                                if (db.t_rm_vip_acclist.OrderByDescending(o => o.ope_date).FirstOrDefault().ope_date.Value.AddDays(30) < DateTime.Now)
                                {
                                    if (mode)
                                    {
                                        MessageBox.Show("距离上次送积分还不到30天 则跳过");
                                    }
                                    continue;
                                }

                            }


                            if (ignoreList.Contains(vipinfo.card_no))
                            {
                                if (mode)
                                {
                                    MessageBox.Show("如果会员忽略列表里存在这个会员卡号，择跳过");
                                }
                                //如果会员忽略列表里存在这个会员卡号，择跳过
                                continue;
                            }

                            if (mode)
                            {
                                MessageBox.Show("vip数量：" + vipInfos.Count.ToString());
                            }
                            vipinfo.acc_num = vipinfo.acc_num + accnum;
                            vipinfo.now_acc_num = vipinfo.now_acc_num + accnum;

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
                        catch (Exception ex)
                        {
                            MessageBox.Show("错误：" + ex.ToString());

                        }
                    }

                    db.SaveChanges();


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
}
