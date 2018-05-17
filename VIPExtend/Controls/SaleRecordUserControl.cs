using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonHelper;
using DataRepository;
using VIPExtend.Frms;

namespace VIPExtend.Controls
{
    public partial class SaleRecordUserControl : UserControl
    {
        public SaleRecordUserControl()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now.AddMonths(-DateTime.Now.Month);
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {

                var vipcardno = textBox1.Text;
                var vipname = textBox2.Text;
                var begindate = dateTimePicker1.Value;
                var enddate = dateTimePicker2.Value;

                var querysql = "select a.com_no, c.card_no, c.vip_name, c.vip_sex, c.vip_start_date, c.vip_end_date, a.oper_date, b.item_brandname, b.item_name ,b.item_no from t_rm_saleflow as a left join t_bd_item_info as b on a.item_no = b.item_no left join t_rm_vip_info as c on a.card_no = c.card_no";


                querysql += "  where a.oper_date >='" + begindate + "' and a.oper_date<='" + enddate + "' ";

                if (!string.IsNullOrEmpty(vipcardno))
                {
                    querysql += " and c.card_no ='" + vipcardno + "'";
                }
                if (!string.IsNullOrEmpty(vipname))
                {
                    querysql += " and c.vip_name like '%" + vipname + "%'";
                }

                var records = db.Database.SqlQuery<SaleRecord>(querysql);

                dataGridView1.DataSource = records.ToList();


            }
        }


        private void Check()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("请选择一条销售记录"); return;
            }

            var record = dataGridView1.CurrentRow.DataBoundItem as SaleRecord;
            if (record != null)
            {
                MaintanceRecordForm frm = new MaintanceRecordForm(record.com_no);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择一条销售记录");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //保养设置
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colSetMaintence")
            {
                var record = dataGridView1.CurrentRow.DataBoundItem as SaleRecord;
                MaintanceRecordSettingForm frm = new MaintanceRecordSettingForm(record);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();

            }
            //查看保养
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colcheck")
            {
                Check();
            }
        }
    }
}
