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

namespace DoAn_LTUDQL2
{
    public partial class uctr_PhucHoi : UserControl
    {
        public uctr_PhucHoi()
        {
            InitializeComponent();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            progressBar_Loading.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(tbx_Server.Text, tbx_Username.Text, tbx_Password.Text));
                Restore dbRestore = new Restore()
                {
                    Database = tbx_database.Text,Action= RestoreActionType.Database,ReplaceDatabase = true,NoRecovery = false
                };
                dbRestore.Devices.AddDevice(@"C:\Data_QLBanHang\QLBanHang.bak", DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lbx_Status.Invoke((MethodInvoker)delegate
                {
                    lbx_Status.Text = e.Error.Message;
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
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
