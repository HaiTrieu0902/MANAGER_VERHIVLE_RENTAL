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

namespace MANAGER_VERHIVLE_RENTAL.HopDong
{
    public partial class frmHopDong : Form
    {
        private string connection = ConfigurationManager.ConnectionStrings["ManagerRental"].ConnectionString;
        public frmHopDong()
        {
            InitializeComponent();
        }

      

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            loadDataHopDong();
            dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable getDSHopDong()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM tblHopDong"
                        , cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable("tblHopDong");
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
        private void loadDataHopDong()
        {
            DataTable dataTable = getDSHopDong();
            dgvHopDong.DataSource = dataTable;

            dgvHopDong.Columns[0].HeaderText = "MÃ PHƯƠNG TIỆN";
            dgvHopDong.Columns[1].HeaderText = "NGÀY THUÊ";
            dgvHopDong.Columns[2].HeaderText = "NGÀY TRẢ";
            dgvHopDong.Columns[3].HeaderText = "TỔNG TIỀN ĐẶT CỌC";
            dgvHopDong.Columns[4].HeaderText = "TỔNG TIỀN THUÊ XE";
            dgvHopDong.Columns[4].HeaderText = "CMND NGUOI THUE";
            dgvHopDong.AllowUserToAddRows = false;

        }

    }
}
