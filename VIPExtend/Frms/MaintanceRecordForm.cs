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
    public partial class MaintanceRecordForm : Form
    {
        public MaintanceRecordForm(decimal saleid)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            using (var db = new Model1())
            {
                dataGridView1.DataSource = db.MaintainRecord.Where(o => o.SallID == saleid).ToList();
            }
        }


    }
}
