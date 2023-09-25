using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using System;

namespace MANAGER_VERHIVLE_RENTAL.Auth
{
    public partial class FrmLogin : Form
    {

        private string connection = ConfigurationManager.ConnectionStrings["ManagerRental"].ConnectionString;


        public FrmLogin()
        {
            InitializeComponent();
        }

     

        private void btn_login_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connection))
                {
                    using (SqlCommand cm = new SqlCommand(
                        @"SELECT *
                  FROM dbo.tblUser 
                  WHERE sEmail = @sEmail AND sSDT = @sSDT", cnn))
                    {
                        cm.Parameters.AddWithValue("@sEmail", txb_username.Text.Trim());
                        cm.Parameters.AddWithValue("@sSDT", txb_password.Text);

                        cm.CommandType = CommandType.Text;
                        cnn.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            DataTable dt = new DataTable("tblHoaDonBan");
                            da.Fill(dt);


                          
                            if (dt.Rows.Count > 0)
                            {
                                frmHome form = new frmHome();
                                this.Hide();
                                form.Show();
                                MessageBox.Show($"Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        cnn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra! {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
