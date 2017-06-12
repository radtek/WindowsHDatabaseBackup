namespace HDatabaseBackup
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.timeBackup = new System.Windows.Forms.DateTimePicker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lstDatabases = new System.Windows.Forms.CheckedListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.grpDatabases = new DevExpress.XtraEditors.GroupControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLastTime = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDatabases)).BeginInit();
            this.grpDatabases.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeBackup
            // 
            this.timeBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeBackup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBackup.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeBackup.Location = new System.Drawing.Point(2, 20);
            this.timeBackup.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.timeBackup.Name = "timeBackup";
            this.timeBackup.Size = new System.Drawing.Size(174, 27);
            this.timeBackup.TabIndex = 0;
            this.timeBackup.ValueChanged += new System.EventHandler(this.timeBackup_ValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.timeBackup);
            this.groupControl1.Location = new System.Drawing.Point(12, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(178, 60);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "وقت النسخة الاحتياطية";
            // 
            // lstDatabases
            // 
            this.lstDatabases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDatabases.FormattingEnabled = true;
            this.lstDatabases.Location = new System.Drawing.Point(2, 29);
            this.lstDatabases.Name = "lstDatabases";
            this.lstDatabases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstDatabases.Size = new System.Drawing.Size(176, 158);
            this.lstDatabases.TabIndex = 2;
            this.lstDatabases.SelectedIndexChanged += new System.EventHandler(this.lstDatabases_SelectedIndexChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Visible = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnBrowse);
            this.groupControl2.Controls.Add(this.txtPath);
            this.groupControl2.Location = new System.Drawing.Point(14, 98);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(178, 67);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "مجلد الحفظ";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowse.Location = new System.Drawing.Point(2, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(174, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPath.Location = new System.Drawing.Point(2, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPath.Size = new System.Drawing.Size(174, 20);
            this.txtPath.TabIndex = 0;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.grpDatabases);
            this.grpMain.Controls.Add(this.statusStrip1);
            this.grpMain.Controls.Add(this.groupControl1);
            this.grpMain.Controls.Add(this.groupControl2);
            this.grpMain.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("الأعدادات", ((System.Drawing.Image)(resources.GetObject("grpMain.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("أغلاق", ((System.Drawing.Image)(resources.GetObject("grpMain.CustomHeaderButtons1"))))});
            this.grpMain.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(205, 401);
            this.grpMain.TabIndex = 4;
            // 
            // grpDatabases
            // 
            this.grpDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDatabases.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpDatabases.CaptionImage")));
            this.grpDatabases.Controls.Add(this.lstDatabases);
            this.grpDatabases.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("نسخة", ((System.Drawing.Image)(resources.GetObject("grpDatabases.CustomHeaderButtons"))))});
            this.grpDatabases.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpDatabases.Location = new System.Drawing.Point(12, 185);
            this.grpDatabases.Name = "grpDatabases";
            this.grpDatabases.Size = new System.Drawing.Size(180, 189);
            this.grpDatabases.TabIndex = 5;
            this.grpDatabases.Text = "قواعد البيانات";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLastTime});
            this.statusStrip1.Location = new System.Drawing.Point(2, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(201, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLastTime
            // 
            this.statusLastTime.Name = "statusLastTime";
            this.statusLastTime.Size = new System.Drawing.Size(0, 17);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 401);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDatabaseBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDatabases)).EndInit();
            this.grpDatabases.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeBackup;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.CheckedListBox lstDatabases;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLastTime;
        private DevExpress.XtraEditors.GroupControl grpDatabases;
    }
}

