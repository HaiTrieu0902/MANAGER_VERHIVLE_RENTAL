using MANAGER_VERHIVLE_RENTAL.Auth;
using MANAGER_VERHIVLE_RENTAL.HopDong;
using MANAGER_VERHIVLE_RENTAL.Kho;
using MANAGER_VERHIVLE_RENTAL.User;
using MANAGER_VERHIVLE_RENTAL.Vehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_VERHIVLE_RENTAL
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void sts_menu_system_Click(object sender, EventArgs e)
        {

        }

     

        private void tlTr_PhuongTien_Click(object sender, EventArgs e)
        {
            frmVehicle PhuongTien = new Vehicle.frmVehicle();
            PhuongTien.MdiParent = this;
            PhuongTien.Show();
        }

        private void tlTr_LoaiPhuongTien_Click(object sender, EventArgs e)
        {
            frmTypeVehicle loaiPhuongTien = new Vehicle.frmTypeVehicle();
            loaiPhuongTien.MdiParent = this;
            loaiPhuongTien.Show();
        }

        private void tlTr_NguoiDung_Click(object sender, EventArgs e)
        {
            frmUser user = new User.frmUser();
            user.MdiParent = this;
            user.Show();
        }

        private void tlTr_Kho_Click(object sender, EventArgs e)
        {
            frmKho kho = new Kho.frmKho();
            kho.MdiParent = this;
            kho.Show();
        }

        private void tlTr_HopDong_Click(object sender, EventArgs e)
        {
            frmHopDong hopdong = new HopDong.frmHopDong();
            hopdong.MdiParent = this;
            hopdong.Show();
        }

        private void tlTr_ThemTaiKhoan_Click(object sender, EventArgs e)
        {
            frmRegister regiter = new Auth.frmRegister();
            regiter.MdiParent = this;
            regiter.Show();

        }
    }
}
