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
using VIPExtend.Controls;

namespace VIPExtend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void 净水器销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Add(new SaleRecordUserControl());

        }

        private void 充值记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(new Vip_AcclistUserControl());

        }
    }
}
