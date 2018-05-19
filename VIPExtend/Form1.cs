using CommonHelper;
using DataRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Task.Factory.StartNew(() =>
            {
                ApplicationInstance.Instance.Alert();
            });
        }


        private void Initializenotifyicon()
        {
            //定义一个MenuItem数组，并把此数组同时赋值给ContextMenu对象
            MenuItem[] mnuItms = new MenuItem[2];
            mnuItms[0] = new MenuItem();
            mnuItms[0].Text = "显示窗口";
            mnuItms[0].Click += new System.EventHandler(this.notifyIcon1_showfrom);
            mnuItms[1] = new MenuItem();
            mnuItms[1].Text = "退出";
            mnuItms[1].Click += new System.EventHandler(this.notifyIcon2_showfrom);

            notifyiconMnu = new ContextMenu(mnuItms);
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenu = notifyiconMnu;
            //为托盘程序加入设定好的ContextMenu对象
        }

        private void notifyIcon1_showfrom(object sender, System.EventArgs e)
        {
            ShowForm();
        }
        private void notifyIcon2_showfrom(object sender, System.EventArgs e)
        {
            ExitApplition();
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

        private void 开机启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                StartUp();
                MessageBox.Show("设置成功");
            }
            catch (Exception)
            {
                MessageBox.Show("设置出错");
            }
        }
        /// <summary>  
        /// 修改程序在注册表中的键值  
        /// </summary>  
        /// <param name="flag">1:开机启动</param>  
        private static void StartUp()
        {
            string path = Application.StartupPath;
            string keyName = path.Substring(path.LastIndexOf("\\") + 1);
            Microsoft.Win32.RegistryKey Rkey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (Rkey == null)
            {
                Rkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                Rkey.SetValue(keyName, System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            }
        }
    }
}
