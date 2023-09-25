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

namespace MANAGER_VERHIVLE_RENTAL.Kho
{
    public partial class frmKho : Form
    {
        private string connection = ConfigurationManager.ConnectionStrings["ManagerRental"].ConnectionString;
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            loadDataKho();
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private DataTable getDSKho()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM tblKho"
                        , cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable("tblKho");
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
        private void loadDataKho()
        {
            DataTable dataTable = getDSKho();
            dgvKho.DataSource = dataTable;

            dgvKho.Columns[0].HeaderText = "MÃ PHƯƠNG TIỆN";
            dgvKho.Columns[1].HeaderText = "TÊN PHƯƠNG TIỆN";
            dgvKho.Columns[2].HeaderText = "ĐƠN GIÁ";
            dgvKho.Columns[3].HeaderText = "TÌNH TRẠNG";
            dgvKho.Columns[4].HeaderText = "MÃ PHIẾU THU";
            dgvKho.AllowUserToAddRows = false;

        }


    }
}
