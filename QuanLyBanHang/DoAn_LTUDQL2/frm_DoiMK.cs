﻿using BUS.BUS;
using BUS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_LTUDQL2
{
    public partial class frm_DoiMK : DevExpress.XtraEditors.XtraForm
    {
        public frm_DoiMK()
        {
            InitializeComponent();
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if (txt_MKCu.Text.Trim() != "" && txt_MKMoi.Text.Trim() != "" && txt_ReMKMoi.Text.Trim() != "")
            {
                if (txt_MKMoi.Text == txt_ReMKMoi.Text)
                {
                    if (DoiMKBUS.DoiMatKhau(txt_MKCu.Text, txt_MKMoi.Text, LoginBUS.Working.MaNV) == 1)
                    {
                        MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thành Công!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        NhatKiHeThongBUS.ThemNhatKi("Đổi mật khẩu","Thay đổi mật khẩu");
                        Close();
                    }
                    else
                        MessageBox.Show("Mật khẩu cũ chưa chính xác", "Báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Mật Khẩu nhập lại không giống với Mật Khẩu mới", "Báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin", "Báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_DoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
