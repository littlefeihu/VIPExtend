using CommonHelper;
using DataRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VIPExtend.Frms
{
    public partial class MaintainenceAlertForm : Form
    {
        public MaintainenceAlertForm(List<SaleRecord> alertData)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = alertData;
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


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
