using CommonHelper;
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
    public partial class MaintanceRecordSettingForm : Form
    {
        SaleRecord _record;

        public MaintanceRecordSettingForm(SaleRecord record)
        {
            InitializeComponent();
            this._record = record;

            using (var db = new Model1())
            {
                comboBox1.DataSource = db.t_rm_saleflow.Select(o => o.sale_man).Distinct().ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                db.MaintainRecord.Add(new MaintainRecord
                {
                    MaintainDate = DateTime.Now,
                    Saleman = comboBox1.SelectedItem.ToString().Trim(),
                    SallID = (int)_record.com_no,
                    Status = 1
                });
                db.SaveChanges();
                label4.Text = "设置保养成功";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                db.MaintainRecord.Add(new MaintainRecord
                {
                    MaintainDate = DateTime.Now,
                    Saleman = comboBox1.SelectedItem.ToString().Trim(),
                    SallID = (int)_record.com_no,
                    Status = 0
                });
                db.SaveChanges();
                label4.Text = "已忽略保养";
            }
        }
    }
}
