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
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace DoAn_LTUDQL2
{
    public partial class frm_PhucHoi : DevExpress.XtraEditors.XtraForm
    {
        public frm_PhucHoi()
        {
            InitializeComponent();
        }

        private void buttonEdit1_Properties_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Backup file (*.bak)|*.bak|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                          buttonEdit_PhucHoi.Text=  openFileDialog1.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btn_PhucHoi_Click(object sender, EventArgs e)
        {
            progressBar_PhucHoi.Value = 0;
            try
            {
                Server dbServer = new Server(new ServerConnection(tbx_Server.Text, tbx_Username.Text, tbx_Pass.Text));
                Restore dbRestore = new Restore()
                {
                    Database = tbx_db.Text,
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };
                if(buttonEdit_PhucHoi.Text == @"C:\Data_QLBanHang\QLBanHang.bak")
                {
                    dbRestore.Devices.AddDevice(@"C:\Data_QLBanHang\QLBanHang.bak", DeviceType.File);
                }
                else
                {
                    dbRestore.Devices.AddDevice(buttonEdit_PhucHoi.Text, DeviceType.File);
                }
               
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lb_TrangThai.Invoke((MethodInvoker)delegate
                {
                    lb_TrangThai.Text = e.Error.Message;
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar_PhucHoi.Invoke((MethodInvoker)delegate
            {

                progressBar_PhucHoi.Value = e.Percent;
                progressBar_PhucHoi.Update();
                lb_Loading.Text = "Loading..." + $"{e.Percent}%";

            });
        }
    }
}