﻿namespace VIPExtend
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查询净水器销售记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.净水器销售记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.充值记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.保养查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.积分充值间隔设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.弹窗时间设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询净水器销售记录ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查询净水器销售记录ToolStripMenuItem
            // 
            this.查询净水器销售记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.净水器销售记录ToolStripMenuItem,
            this.充值记录ToolStripMenuItem,
            this.保养查询ToolStripMenuItem});
            this.查询净水器销售记录ToolStripMenuItem.Name = "查询净水器销售记录ToolStripMenuItem";
            this.查询净水器销售记录ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询净水器销售记录ToolStripMenuItem.Text = "查询";
            // 
            // 净水器销售记录ToolStripMenuItem
            // 
            this.净水器销售记录ToolStripMenuItem.Name = "净水器销售记录ToolStripMenuItem";
            this.净水器销售记录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.净水器销售记录ToolStripMenuItem.Text = "净水器销售记录";
            this.净水器销售记录ToolStripMenuItem.Click += new System.EventHandler(this.净水器销售记录ToolStripMenuItem_Click);
            // 
            // 充值记录ToolStripMenuItem
            // 
            this.充值记录ToolStripMenuItem.Name = "充值记录ToolStripMenuItem";
            this.充值记录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.充值记录ToolStripMenuItem.Text = "积分记录";
            this.充值记录ToolStripMenuItem.Click += new System.EventHandler(this.充值记录ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.积分充值间隔设置ToolStripMenuItem,
            this.弹窗时间设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 495);
            this.panel1.TabIndex = 2;
            // 
            // 保养查询ToolStripMenuItem
            // 
            this.保养查询ToolStripMenuItem.Name = "保养查询ToolStripMenuItem";
            this.保养查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保养查询ToolStripMenuItem.Text = "保养查询";
            // 
            // 积分充值间隔设置ToolStripMenuItem
            // 
            this.积分充值间隔设置ToolStripMenuItem.Name = "积分充值间隔设置ToolStripMenuItem";
            this.积分充值间隔设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.积分充值间隔设置ToolStripMenuItem.Text = "积分充值间隔设置";
            // 
            // 弹窗时间设置ToolStripMenuItem
            // 
            this.弹窗时间设置ToolStripMenuItem.Name = "弹窗时间设置ToolStripMenuItem";
            this.弹窗时间设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.弹窗时间设置ToolStripMenuItem.Text = "弹窗时间设置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "小帮手";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询净水器销售记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 净水器销售记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 充值记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 保养查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 积分充值间隔设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 弹窗时间设置ToolStripMenuItem;
    }
}
