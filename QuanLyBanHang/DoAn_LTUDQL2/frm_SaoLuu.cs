using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace DoAn_LTUDQL2
{
    public partial class frm_SaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public frm_SaoLuu()
        {
            InitializeComponent();
        }

        private void buttonEdit1_Properties_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            buttonEdit_SaoLuu.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            progressBar_Loading.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(tbx_Server.Text, tbx_Username.Text, tbx_Pass.Text));
                Backup dbBackup = new Backup()
                {
                    Action = BackupActionType.Database,
                    Database = tbx_database.Text
                };
                if ( buttonEdit_SaoLuu.Text == @"C:\Data_QLBanHang\")
                {
                    System.IO.Directory.CreateDirectory(@"C:\Data_QLBanHang\");
                    dbBackup.Devices.AddDevice(@"C:\Data_QLBanHang\QLBanHang.bak", DeviceType.File);
                }
                else
                {
                    System.IO.Directory.CreateDirectory(buttonEdit_SaoLuu.Text + @"\QLBanHang");
                    var a = buttonEdit_SaoLuu.Text + @"\QLBanHang.bak";
                    dbBackup.Devices.AddDevice(a, DeviceType.File);

                }
                
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lb_TrangThai.Invoke((MethodInvoker)delegate
                {
                    lb_TrangThai.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar_Loading.Invoke((MethodInvoker)delegate
                {

                    progressBar_Loading.Value = e.Percent;
                    progressBar_Loading.Update();
                    label_Loading.Text = "Loading..." + $"{e.Percent}%";

                });
        }

    }
}