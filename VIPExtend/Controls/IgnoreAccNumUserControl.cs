using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommonHelper;

namespace VIPExtend.Controls
{
    public partial class IgnoreAccNumUserControl : UserControl
    {
        string IgnoreVIP = "IgnoreVIP";
        public IgnoreAccNumUserControl()
        {
            InitializeComponent();
            var ignoretxt = INIHelper.ReadString(IgnoreVIP, DirectoryManage.GetINIFullPath());
            textBox1.Text = ignoretxt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            INIHelper.WriteString(IgnoreVIP, textBox1.Text.Trim(), DirectoryManage.GetINIFullPath());
            MessageBox.Show("保存成功");
        }
    }
}
