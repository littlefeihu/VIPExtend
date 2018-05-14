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
            using (var db = new Model1())
            {

                var vipcardno = textBox1.Text;

                var querysql = "select [card_no] ,[ope_date],[acc_num] ,[oper_des]   FROM [dbo].[t_rm_vip_acclist] ";

                if (!string.IsNullOrEmpty(vipcardno))
                {
                    querysql += " where  card_no  = '" + vipcardno + "'";
                }
           
                var records = db.Database.SqlQuery<Vip_Acclist>(querysql);

                dataGridView1.DataSource = records.ToList();


            }
        }
    }
}
