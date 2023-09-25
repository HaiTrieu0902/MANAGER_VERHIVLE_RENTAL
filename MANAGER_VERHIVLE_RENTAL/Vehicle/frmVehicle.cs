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
    public partial class frmVehicle : Form
    {

        private string connection = ConfigurationManager.ConnectionStrings["ManagerRental"].ConnectionString;
        public frmVehicle()
        {
            InitializeComponent();
        }


        private void frmVehicle_Load(object sender, EventArgs e)
        {
            loadDataVerhical();
            dgvPhuongTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPhuongTien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private DataTable getDSVerhical()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM tblVehicle"
                        , cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable(" tblVehicle");
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
        private void loadDataVerhical()
        {
            DataTable dataTable = getDSVerhical();
            dgvPhuongTien.DataSource = dataTable;

            dgvPhuongTien.Columns[0].HeaderText = "MÃ PHƯƠNG TIỆN";
            dgvPhuongTien.Columns[1].HeaderText = "TÊN PHƯƠNG TIỆN";
            dgvPhuongTien.Columns[2].HeaderText = "ĐƠN GIÁ";
            dgvPhuongTien.Columns[3].HeaderText = "TÌNH TRẠNG";
            dgvPhuongTien.Columns[4].HeaderText = "MÃ PHIẾU THU";
            dgvPhuongTien.AllowUserToAddRows = false;

        }

       
    }
}
