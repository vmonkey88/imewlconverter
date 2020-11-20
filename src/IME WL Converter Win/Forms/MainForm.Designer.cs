﻿namespace Studyzy.IMEWLConverter
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnConvert = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txbWLPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilterConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRankGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExportDirectly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStreamExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMergeToOneFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChineseTransConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAccessWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemSplitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMergeWL = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(620, 34);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 64);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "转 换";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 109);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(703, 385);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // txbWLPath
            // 
            this.txbWLPath.Location = new System.Drawing.Point(16, 34);
            this.txbWLPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbWLPath.Name = "txbWLPath";
            this.txbWLPath.Size = new System.Drawing.Size(527, 25);
            this.txbWLPath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文件|*.txt|微软拼音|*.dctx|所有文件|*.*";
            this.saveFileDialog1.Title = "请选择导出词库保存的文件位置";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(552, 32);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(44, 29);
            this.btnOpenFileDialog.TabIndex = 3;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // cbxFrom
            // 
            this.cbxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFrom.DropDownWidth = 150;
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Location = new System.Drawing.Point(16, 72);
            this.cbxFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(260, 23);
            this.cbxFrom.TabIndex = 4;
            this.cbxFrom.SelectedIndexChanged += new System.EventHandler(this.cbxFrom_SelectedIndexChanged);
            // 
            // cbxTo
            // 
            this.cbxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Location = new System.Drawing.Point(335, 72);
            this.cbxTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(260, 23);
            this.cbxTo.TabIndex = 4;
            this.cbxTo.SelectedIndexChanged += new System.EventHandler(this.cbxTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "-->>";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(732, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFilterConfig,
            this.ToolStripMenuItemRankGenerate,
            this.toolStripSeparator2,
            this.toolStripMenuItemExportDirectly,
            this.toolStripMenuItemStreamExport,
            this.toolStripMenuItemMergeToOneFile,
            this.ToolStripMenuItemChineseTransConfig});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItem1.Text = "高级设置";
            // 
            // toolStripMenuItemFilterConfig
            // 
            this.toolStripMenuItemFilterConfig.Name = "toolStripMenuItemFilterConfig";
            this.toolStripMenuItemFilterConfig.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemFilterConfig.Text = "词条过滤设置";
            this.toolStripMenuItemFilterConfig.Click += new System.EventHandler(this.toolStripMenuItemFilterConfig_Click);
            // 
            // ToolStripMenuItemRankGenerate
            // 
            this.ToolStripMenuItemRankGenerate.Name = "ToolStripMenuItemRankGenerate";
            this.ToolStripMenuItemRankGenerate.Size = new System.Drawing.Size(242, 26);
            this.ToolStripMenuItemRankGenerate.Text = "词频生成设置";
            this.ToolStripMenuItemRankGenerate.Click += new System.EventHandler(this.ToolStripMenuItemRankGenerate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(239, 6);
            // 
            // toolStripMenuItemExportDirectly
            // 
            this.toolStripMenuItemExportDirectly.CheckOnClick = true;
            this.toolStripMenuItemExportDirectly.Name = "toolStripMenuItemExportDirectly";
            this.toolStripMenuItemExportDirectly.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemExportDirectly.Text = "不显示结果，直接导出";
            this.toolStripMenuItemExportDirectly.Click += new System.EventHandler(this.toolStripMenuItemExportDirectly_Click);
            // 
            // toolStripMenuItemStreamExport
            // 
            this.toolStripMenuItemStreamExport.CheckOnClick = true;
            this.toolStripMenuItemStreamExport.Name = "toolStripMenuItemStreamExport";
            this.toolStripMenuItemStreamExport.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemStreamExport.Text = "一边读取，一边导出";
            this.toolStripMenuItemStreamExport.ToolTipText = "目前只有文本格式的词库才能支持该功能";
            this.toolStripMenuItemStreamExport.Click += new System.EventHandler(this.toolStripMenuItemStreamExport_Click);
            // 
            // toolStripMenuItemMergeToOneFile
            // 
            this.toolStripMenuItemMergeToOneFile.Checked = true;
            this.toolStripMenuItemMergeToOneFile.CheckOnClick = true;
            this.toolStripMenuItemMergeToOneFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemMergeToOneFile.Name = "toolStripMenuItemMergeToOneFile";
            this.toolStripMenuItemMergeToOneFile.Size = new System.Drawing.Size(242, 26);
            this.toolStripMenuItemMergeToOneFile.Text = "合并多词库到一个文件";
            this.toolStripMenuItemMergeToOneFile.Click += new System.EventHandler(this.toolStripMenuItemMergeToOneFile_Click);
            // 
            // ToolStripMenuItemChineseTransConfig
            // 
            this.ToolStripMenuItemChineseTransConfig.Name = "ToolStripMenuItemChineseTransConfig";
            this.ToolStripMenuItemChineseTransConfig.Size = new System.Drawing.Size(242, 26);
            this.ToolStripMenuItemChineseTransConfig.Text = "简繁体转换设置";
            this.ToolStripMenuItemChineseTransConfig.Click += new System.EventHandler(this.ToolStripMenuItemChineseTransConfig_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDonate,
            this.ToolStripMenuItemHelp,
            this.ToolStripMenuItemAbout,
            this.ToolStripMenuItemAccessWebSite,
            this.toolStripSeparator3,
            this.ToolStripMenuItemSplitFile,
            this.ToolStripMenuItemMergeWL});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(53, 26);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // ToolStripMenuItemDonate
            // 
            this.ToolStripMenuItemDonate.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemDonate.Image")));
            this.ToolStripMenuItemDonate.Name = "ToolStripMenuItemDonate";
            this.ToolStripMenuItemDonate.Size = new System.Drawing.Size(182, 26);
            this.ToolStripMenuItemDonate.Text = "捐贈";
            this.ToolStripMenuItemDonate.Click += new System.EventHandler(this.ToolStripMenuItemDonate_Click);
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(182, 26);
            this.ToolStripMenuItemHelp.Text = "帮助";
            this.ToolStripMenuItemHelp.Click += new System.EventHandler(this.ToolStripMenuItemHelp_Click);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(182, 26);
            this.ToolStripMenuItemAbout.Text = "关于";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // ToolStripMenuItemAccessWebSite
            // 
            this.ToolStripMenuItemAccessWebSite.Name = "ToolStripMenuItemAccessWebSite";
            this.ToolStripMenuItemAccessWebSite.Size = new System.Drawing.Size(182, 26);
            this.ToolStripMenuItemAccessWebSite.Text = "查看最新版本";
            this.ToolStripMenuItemAccessWebSite.Click += new System.EventHandler(this.ToolStripMenuItemAccessWebSite_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // ToolStripMenuItemSplitFile
            // 
            this.ToolStripMenuItemSplitFile.Name = "ToolStripMenuItemSplitFile";
            this.ToolStripMenuItemSplitFile.Size = new System.Drawing.Size(182, 26);
            this.ToolStripMenuItemSplitFile.Text = "文件分割";
            this.ToolStripMenuItemSplitFile.Click += new System.EventHandler(this.ToolStripMenuItemSplitFile_Click);
            // 
            // ToolStripMenuItemMergeWL
            // 
            this.ToolStripMenuItemMergeWL.Name = "ToolStripMenuItemMergeWL";
            this.ToolStripMenuItemMergeWL.Size = new System.Drawing.Size(182, 26);
            this.ToolStripMenuItemMergeWL.Text = "词库合并";
            this.ToolStripMenuItemMergeWL.Click += new System.EventHandler(this.ToolStripMenuItemMergeWL_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(732, 26);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 18);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(189, 20);
            this.toolStripStatusLabel1.Text = "欢迎使用深蓝词库转换工具";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 528);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTo);
            this.Controls.Add(this.cbxFrom);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.txbWLPath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "深蓝词库转换";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txbWLPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.ComboBox cbxFrom;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFilterConfig;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAccessWebSite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExportDirectly;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStreamExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMergeToOneFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDonate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSplitFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChineseTransConfig;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMergeWL;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRankGenerate;
    }
}

