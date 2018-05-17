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


        public void Init()
        {
            timer1.Interval = 1000 * 3;
            timer1.Enabled = true;
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Start();
        }

        bool isRunning = false;
        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;

                List<SaleRecord> alertData = new List<SaleRecord>();
                var AlertTimes = System.Configuration.ConfigurationManager.AppSettings["AlertTimes"];
                using (var db = new Model1())
                {
                    SqlParameter[] sqlParms = new SqlParameter[1];
                    sqlParms[0] = new SqlParameter("@alerttimes", AlertTimes);
                    alertData = db.Database.SqlQuery<SaleRecord>("exec QuerySaleRecrod @alerttimes", sqlParms).ToList();
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
