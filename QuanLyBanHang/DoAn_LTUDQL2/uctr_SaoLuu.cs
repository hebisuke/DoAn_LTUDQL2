using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;

namespace DoAn_LTUDQL2
{
    public partial class uctr_SaoLuu : UserControl
    {
        public uctr_SaoLuu()
        {
            InitializeComponent();
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
                    Database = tbx_db.Text
                };
               
                System.IO.Directory.CreateDirectory(@"C:\Data_QLBanHang\");
                dbBackup.Devices.AddDevice(@"C:\Data_QLBanHang\QLBanHang.bak", DeviceType.File);
                dbBackup.Initialize = true;
                dbBackup.PercentComplete += DbBackup_PercentComplete;
                dbBackup.Complete += DbBackup_Complete;
                dbBackup.SqlBackupAsync(dbServer);
                btn_SaoLuu.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if(e.Error !=null)
            {
                lbx_TrangThai.Invoke((MethodInvoker)delegate
                {
                    lbx_TrangThai.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar_Loading.Invoke((MethodInvoker)delegate
            {

                progressBar_Loading.Value = e.Percent;
                progressBar_Loading.Update();
                layoutControlItem_Loading.Text = "Loading..." + $"{e.Percent}%";

            });
            
        }
    }
}
