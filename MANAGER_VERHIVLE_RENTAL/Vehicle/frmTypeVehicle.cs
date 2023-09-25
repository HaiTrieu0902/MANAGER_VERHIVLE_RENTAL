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

namespace MANAGER_VERHIVLE_RENTAL.Vehicle
{
    public partial class frmTypeVehicle : Form
    {

        private string connection = ConfigurationManager.ConnectionStrings["ManagerRental"].ConnectionString;
        public frmTypeVehicle()
        {
            InitializeComponent();
        }

        private void frmTypeVehicle_Load(object sender, EventArgs e)
        {
            loadDataTypeVerhical();
            dgvPhuongTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPhuongTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private DataTable getDSTypeVerhical()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM tblLoaiPhuongTien"
                        , cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable("tblLoaiPhuongTien");
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
        private void loadDataTypeVerhical()
        {
            DataTable dataTable = getDSTypeVerhical();
            dgvPhuongTien.DataSource = dataTable;
            dgvPhuongTien.Columns[0].HeaderText = "MÃ NSX";
            dgvPhuongTien.Columns[1].HeaderText = "MÃ PHƯƠNG TIÊN";
            dgvPhuongTien.Columns[2].HeaderText = "HÃNG SX";
            dgvPhuongTien.Columns[3].HeaderText = "SỐ LƯỢNG";
            dgvPhuongTien.Columns[4].HeaderText = "TỔNG TIỀN";
            dgvPhuongTien.AllowUserToAddRows = false;

        }

    }
}
