namespace MANAGER_VERHIVLE_RENTAL.Vehicle
{
    partial class frmTypeVehicle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Button();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.btnLuu = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaNSX = new System.Windows.Forms.TextBox();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblHangsx = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblMaPhuongTien = new System.Windows.Forms.Label();
            this.lblTongtienAll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(193, 750);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 42);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(752, 202);
            this.txbDonGia.Multiline = true;
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(332, 28);
            this.txbDonGia.TabIndex = 64;
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.AllowUserToAddRows = false;
            this.dgvPhuongTien.AllowUserToDeleteRows = false;
            this.dgvPhuongTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuongTien.Location = new System.Drawing.Point(3, 2);
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.ReadOnly = true;
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.RowTemplate.Height = 24;
            this.dgvPhuongTien.Size = new System.Drawing.Size(925, 269);
            this.dgvPhuongTien.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPhuongTien);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách loại phương tiện";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Location = new System.Drawing.Point(629, 408);
            this.txbTimKiem.Multiline = true;
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(332, 39);
            this.txbTimKiem.TabIndex = 67;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(568, 750);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 42);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(752, 750);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 42);
            this.btnXoa.TabIndex = 61;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.Location = new System.Drawing.Point(938, 750);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(110, 42);
            this.btnHuyBo.TabIndex = 60;
            this.btnHuyBo.Text = "Hủy";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(967, 410);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 39);
            this.btnTimKiem.TabIndex = 58;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(148, 426);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(936, 298);
            this.tabControl2.TabIndex = 59;
            this.tabControl2.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(374, 750);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 42);
            this.btnLuu.TabIndex = 63;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Title.Location = new System.Drawing.Point(396, 47);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(500, 36);
            this.Title.TabIndex = 57;
            this.Title.Text = "DANH MỤC  LOẠI PHƯƠNG TIỆN";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(667, 205);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(71, 18);
            this.lblSoLuong.TabIndex = 56;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(752, 136);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(328, 28);
            this.txtSDT.TabIndex = 54;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(260, 202);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(358, 28);
            this.txtTenKH.TabIndex = 53;
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.Location = new System.Drawing.Point(260, 136);
            this.txtMaNSX.Multiline = true;
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Size = new System.Drawing.Size(358, 28);
            this.txtMaNSX.TabIndex = 52;
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtien.Location = new System.Drawing.Point(149, 276);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(73, 18);
            this.lblTongtien.TabIndex = 51;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // lblHangsx
            // 
            this.lblHangsx.AutoSize = true;
            this.lblHangsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangsx.Location = new System.Drawing.Point(665, 139);
            this.lblHangsx.Name = "lblHangsx";
            this.lblHangsx.Size = new System.Drawing.Size(71, 18);
            this.lblHangsx.TabIndex = 50;
            this.lblHangsx.Text = "Hãng SX:";
            this.lblHangsx.UseMnemonic = false;
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPT.Location = new System.Drawing.Point(152, 205);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(56, 18);
            this.lblMaPT.TabIndex = 49;
            this.lblMaPT.Text = "Mã PT:";
            // 
            // lblMaPhuongTien
            // 
            this.lblMaPhuongTien.AutoSize = true;
            this.lblMaPhuongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPhuongTien.Location = new System.Drawing.Point(152, 139);
            this.lblMaPhuongTien.Name = "lblMaPhuongTien";
            this.lblMaPhuongTien.Size = new System.Drawing.Size(68, 18);
            this.lblMaPhuongTien.TabIndex = 48;
            this.lblMaPhuongTien.Text = "Mã NSX:";
            // 
            // lblTongtienAll
            // 
            this.lblTongtienAll.AutoSize = true;
            this.lblTongtienAll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTongtienAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtienAll.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTongtienAll.Location = new System.Drawing.Point(254, 276);
            this.lblTongtienAll.Name = "lblTongtienAll";
            this.lblTongtienAll.Size = new System.Drawing.Size(95, 18);
            this.lblTongtienAll.TabIndex = 69;
            this.lblTongtienAll.Text = "350,000 VNĐ";
            // 
            // frmTypeVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 838);
            this.Controls.Add(this.lblTongtienAll);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbDonGia);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaNSX);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.lblHangsx);
            this.Controls.Add(this.lblMaPT);
            this.Controls.Add(this.lblMaPhuongTien);
            this.Name = "frmTypeVehicle";
            this.Text = "frmTypeVehicle";
            this.Load += new System.EventHandler(this.frmTypeVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaNSX;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblHangsx;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblMaPhuongTien;
        private System.Windows.Forms.Label lblTongtienAll;
    }
}