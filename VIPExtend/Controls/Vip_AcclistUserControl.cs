using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataRepository;
using CommonHelper;
using VIPExtend.Frms;

namespace VIPExtend.Controls
{
    public partial class Vip_AcclistUserControl : UserControl
    {
        public Vip_AcclistUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }


        private void Search()
        {

            var vipcardno = textBox1.Text;

            if (string.IsNullOrEmpty(vipcardno))
            {
                MessageBox.Show("会员卡号不能为空");
                return;
            }


            using (var db = new Model1())
            {



                var querysql = "select [card_no] ,[ope_date],[acc_num] ,[oper_des]   FROM [dbo].[t_rm_vip_acclist] ";

                if (!string.IsNullOrEmpty(vipcardno))
                {
                    querysql += " where  card_no  = '" + vipcardno + "'";
                }

                var vipinfo = db.t_rm_vip_info.FirstOrDefault(o => o.card_no == vipcardno);

                if (vipinfo == null)
                {
                    MessageBox.Show("会员账号不存在，请检查"); return;
                }

                var records = db.Database.SqlQuery<Vip_Acclist>(querysql);

                label2.Text = "积分总数：" + vipinfo.now_acc_num;

                dataGridView1.DataSource = records.ToList();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new AddVipAccForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            Search();
        }
    }
}
