using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HDatabaseConnection;
using HRegsiter;
using System.Threading;

namespace HDatabaseBackup
{
    public partial class Home : Form
    {
        #region Properties
        //Database Server Variable
        HMySQLConnection connection;

        //Register Variable
        Product productRegister;

        //Timer for create backup
        private System.Threading.Timer timer;
        #endregion
        public Home()
        {
            InitializeComponent();

            //Notify
            notifyIcon1.Text = Application.ProductName;
            notifyIcon1.Icon = Properties.Resources.backup;
            notifyIcon1.DoubleClick += NotifyIcon1_DoubleClick;

            //Initilize Register to get Data from it
            productRegister = new Product(Application.ExecutablePath);

            //Auto Start-Up 
            Microsoft.Win32.Registry.CurrentUser
                .OpenSubKey("SOFTWARE")
                .OpenSubKey("Microsoft")
                .OpenSubKey("Windows")
                .OpenSubKey("CurrentVersion")
                .OpenSubKey("Run", true)
                .SetValue(Application.ProductName, Application.ExecutablePath);

            //Database Object initilize from register
            connection = new HMySQLConnection(
                productRegister.getValue((int)Enumerators.Settings.ServerIp),
                productRegister.getValue((int)Enumerators.Settings.DatabaseUsername),
                productRegister.getValue((int)Enumerators.Settings.DatabasePassword),
                "information_schema"
                );


            //Event grpMain Click CustomButtons
            grpMain.CustomButtonClick += GrpMain_CustomButtonClick;
            grpDatabases.CustomButtonClick += GrpDatabases_CustomButtonClick;

            //get Databases names from Database Server
            lstDatabases.Items.AddRange(getDatabases().ToArray());

            //Select databases that selected before
            string[] selectedDatabases = productRegister.getValue((int)Enumerators.Settings.Databases).Split(';');
            for (int i = 0; i < selectedDatabases.Length; i++)
            {
                for (int j = 0; j < lstDatabases.Items.Count; j++)
                {
                    if (selectedDatabases[i] == lstDatabases.Items[j].ToString())
                    {
                        lstDatabases.SetItemChecked(j, true);
                    }
                }
            }

            //get Path of backups
            txtPath.Text = productRegister.getValue((int)Enumerators.Settings.FolderBackupPath);

            //Get Time
            DateTime time = new DateTime(Int64.Parse(productRegister.getValue((int)Enumerators.Settings.TimeBackup)));
            timeBackup.Value = new DateTime(timeBackup.Value.Year, timeBackup.Value.Month, timeBackup.Value.Day, time.Hour, time.Minute, time.Second);

            //
            setupTimer();

            //Hide when start-up
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(1000, Application.ProductName, "يعمل في الخلفية", ToolTipIcon.Info);
        }
        /// <summary>
        /// Event for grpDatabases when click one of custom buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GrpDatabases_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "نسخة":
                    backup();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Get databases names from database server
        /// </summary>
        /// <returns></returns>
        List<string> getDatabases()
        {
            List<string> databases = new List<string>();
            System.Data.DataTable dt = connection.query("select schema_name from information_schema.schemata;");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                databases.Add(dt.Rows[i][0].ToString());
            }

            return databases;
        }
        /// <summary>
        /// setup time to get backup
        /// </summary>
        private void setupTimer()
        {
            DateTime current = DateTime.Now;
            DateTime backupTime = new DateTime(long.Parse(productRegister.getValue((int)Enumerators.Settings.TimeBackup)));
            TimeSpan doAt = backupTime.TimeOfDay - current.TimeOfDay;
            if (doAt < TimeSpan.Zero)
            {
                return;
            }
            this.timer = new System.Threading.Timer(x =>
            {
                backup();
            }, null, doAt, Timeout.InfiniteTimeSpan);
        }
        /// <summary>
        /// get backup
        /// </summary>
        void backup()
        {
            HMySQLConnection con;
            for (int i = 0; i < lstDatabases.CheckedItems.Count; i++)
            {
                con = new HMySQLConnection(
                    productRegister.getValue((int)Enumerators.Settings.ServerIp),
                    productRegister.getValue((int)Enumerators.Settings.DatabaseUsername),
                    productRegister.getValue((int)Enumerators.Settings.DatabasePassword),
                    lstDatabases.CheckedItems[i].ToString()
                    );
                string s = productRegister.getValue((int)Enumerators.Settings.FolderBackupPath);
                con.backup(
                    s
                    +
                    "\\"
                    +
                    string.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}.sql",
                    Application.ProductName,
                    lstDatabases.CheckedItems[i].ToString(),
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second
                    ));
            }
            notifyIcon1.ShowBalloonTip(1000, "نسخة احتياطية", "تم اخذ نسخة احتياطية", ToolTipIcon.Info);
            statusLastTime.Text = "اخر نسخة احتياطية " + DateTime.Now;
        }
        private void GrpMain_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "أغلاق":
                    this.Close();
                    break;
                default:
                    break;
            }
        }
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIcon1.ShowBalloonTip(1000, Application.ProductName, "يعمل في الخلفية", ToolTipIcon.Info);
            Hide();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
                productRegister.setValue((int)Enumerators.Settings.FolderBackupPath, txtPath.Text);
            }
        }
        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            Activate();
        }
        private void lstDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = "";
            for (int i = 0; i < lstDatabases.CheckedItems.Count; i++)
            {
                data += lstDatabases.CheckedItems[i].ToString() + ";";
            }
            productRegister.setValue((int)Enumerators.Settings.Databases, data);
        }
        private void timeBackup_ValueChanged(object sender, EventArgs e)
        {
            productRegister.setValue((int)Enumerators.Settings.TimeBackup, timeBackup.Value.TimeOfDay.Ticks.ToString());
        }
    }
}
