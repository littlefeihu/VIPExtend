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
        private ContextMenu notifyiconMnu;
        public Form1()
        {
            InitializeComponent();
            Initializenotifyicon();
            this.SizeChanged += TechSvrForm_SizeChanged;
            AddControl(new SaleRecordUserControl());
        }


        private void Initializenotifyicon()
        {
            //定义一个MenuItem数组，并把此数组同时赋值给ContextMenu对象
            MenuItem[] mnuItms = new MenuItem[1];
            mnuItms[0] = new MenuItem();
            mnuItms[0].Text = "显示窗口";
            mnuItms[0].Click += new System.EventHandler(this.notifyIcon1_showfrom);

            notifyiconMnu = new ContextMenu(mnuItms);
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenu = notifyiconMnu;
            //为托盘程序加入设定好的ContextMenu对象
        }

        private void notifyIcon1_showfrom(object sender, System.EventArgs e)
        {
            ShowForm();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            HideForm();
            e.Cancel = true;
        }

        private void ExitApplition()
        {
            if (MessageBox.Show("确认退出吗？", "退出系统", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
        }
        private void TechSvrForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                this.HideForm();
            }
        }
        public void ShowForm()
        {
            this.Show();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.WindowState = FormWindowState.Normal;
        }

        public void HideForm()
        {
            this.Hide();
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }

        private void 净水器销售记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControl(new SaleRecordUserControl());
        }
        private void 充值记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddControl(new Vip_AcclistUserControl());

        }

        private void AddControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }
    }
}
