using DataRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIPExtend.Frms
{
    public partial class AddVipAccForm : Form
    {
        public AddVipAccForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cardno = textBox1.Text;
            var accnumtext = textBox2.Text;
            var remark = textBox3.Text;
            if (string.IsNullOrEmpty(cardno))
            {
                MessageBox.Show("卡号不能为空");
                return;
            }
            decimal accnum = 0;
            if (!decimal.TryParse(accnumtext, out accnum))
            {
                MessageBox.Show("积分格式不正确");
                return;
            }


            using (var db = new Model1())
            {

                var vipinfo = db.t_rm_vip_info.FirstOrDefault(o => o.card_no == cardno);

                if (vipinfo == null)
                {
                    MessageBox.Show("会员卡号不存在，请重新输入");
                    return;
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
                    oper_des = remark
                });
                db.SaveChanges();
            }
        }
    }
}
