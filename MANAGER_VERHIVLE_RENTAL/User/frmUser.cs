using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_VERHIVLE_RENTAL.User
{
    public partial class frmUser : Form
    {
        private string connection = ConfigurationManager.ConnectionStrings["ManagerRental"].ConnectionString;
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            loadDataNguoiDung();
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable getDSNguoiDung()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM tblUser"
                        , cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable("tblUser");
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }
        private void loadDataNguoiDung()
        {
            DataTable dataTable = getDSNguoiDung();
            dgvNguoiDung.DataSource = dataTable;
            dgvNguoiDung.Columns[0].HeaderText = "MÃ USER";
            dgvNguoiDung.Columns[1].HeaderText = "HỌ VÀ TÊN";
            dgvNguoiDung.Columns[2].HeaderText = "ĐỊA CHỈ";
            dgvNguoiDung.Columns[3].HeaderText = "NGÀY SINH";
            dgvNguoiDung.Columns[4].HeaderText = "SDT";
            dgvNguoiDung.Columns[5].HeaderText = "EMAIL";
            dgvNguoiDung.Columns[6].HeaderText = "CMND";
            dgvNguoiDung.AllowUserToAddRows = false;

        }
    }
}
