﻿
namespace QuanLiCuaHangDienThoai.Forms
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_DoanhThu = new System.Windows.Forms.TabPage();
            this.dataGridView_DT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.tabPage_SanPham = new System.Windows.Forms.TabPage();
            this.dataGridView_SP = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ReloadSP = new System.Windows.Forms.Button();
            this.button_SuaSP = new System.Windows.Forms.Button();
            this.button_XoaSP = new System.Windows.Forms.Button();
            this.button_ThemSP = new System.Windows.Forms.Button();
            this.tabPage_DanhMuc = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_ReloadDM = new System.Windows.Forms.Button();
            this.button_SuaDM = new System.Windows.Forms.Button();
            this.button_XoaDM = new System.Windows.Forms.Button();
            this.button_ThemDM = new System.Windows.Forms.Button();
            this.dataGridView_DM = new System.Windows.Forms.DataGridView();
            this.tabPage4_TaiKhoan = new System.Windows.Forms.TabPage();
            this.dataGridView_TK = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_ReloadTK = new System.Windows.Forms.Button();
            this.button_SuaTK = new System.Windows.Forms.Button();
            this.button_XoaTK = new System.Windows.Forms.Button();
            this.button_ThemTK = new System.Windows.Forms.Button();
            this.textBox_MaSP = new System.Windows.Forms.TextBox();
            this.textBox_TenSP = new System.Windows.Forms.TextBox();
            this.textBox_Gia = new System.Windows.Forms.TextBox();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.textBox_TenDM = new System.Windows.Forms.TextBox();
            this.textBox_MaDM = new System.Windows.Forms.TextBox();
            this.textBox_Loai = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_NgayTao = new System.Windows.Forms.TextBox();
            this.dateTimePicker_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_ToDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage_DoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DT)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage_DanhMuc.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DM)).BeginInit();
            this.tabPage4_TaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TK)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_DoanhThu);
            this.tabControl1.Controls.Add(this.tabPage_SanPham);
            this.tabControl1.Controls.Add(this.tabPage_DanhMuc);
            this.tabControl1.Controls.Add(this.tabPage4_TaiKhoan);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_DoanhThu
            // 
            this.tabPage_DoanhThu.Controls.Add(this.dataGridView_DT);
            this.tabPage_DoanhThu.Controls.Add(this.panel1);
            this.tabPage_DoanhThu.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DoanhThu.Name = "tabPage_DoanhThu";
            this.tabPage_DoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DoanhThu.Size = new System.Drawing.Size(768, 397);
            this.tabPage_DoanhThu.TabIndex = 0;
            this.tabPage_DoanhThu.Text = "Doanh thu";
            this.tabPage_DoanhThu.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DT
            // 
            this.dataGridView_DT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DT.Location = new System.Drawing.Point(218, 7);
            this.dataGridView_DT.Name = "dataGridView_DT";
            this.dataGridView_DT.RowHeadersWidth = 51;
            this.dataGridView_DT.RowTemplate.Height = 24;
            this.dataGridView_DT.Size = new System.Drawing.Size(544, 384);
            this.dataGridView_DT.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker_ToDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker_FromDate);
            this.panel1.Controls.Add(this.button_ThongKe);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 385);
            this.panel1.TabIndex = 0;
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.Location = new System.Drawing.Point(55, 158);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(94, 55);
            this.button_ThongKe.TabIndex = 0;
            this.button_ThongKe.Text = "Thống Kê";
            this.button_ThongKe.UseVisualStyleBackColor = true;
            // 
            // tabPage_SanPham
            // 
            this.tabPage_SanPham.Controls.Add(this.dataGridView_SP);
            this.tabPage_SanPham.Controls.Add(this.panel2);
            this.tabPage_SanPham.Location = new System.Drawing.Point(4, 25);
            this.tabPage_SanPham.Name = "tabPage_SanPham";
            this.tabPage_SanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SanPham.Size = new System.Drawing.Size(768, 397);
            this.tabPage_SanPham.TabIndex = 1;
            this.tabPage_SanPham.Text = "Sản Phẩm";
            this.tabPage_SanPham.UseVisualStyleBackColor = true;
            // 
            // dataGridView_SP
            // 
            this.dataGridView_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SP.Location = new System.Drawing.Point(232, 7);
            this.dataGridView_SP.Name = "dataGridView_SP";
            this.dataGridView_SP.RowHeadersWidth = 51;
            this.dataGridView_SP.RowTemplate.Height = 24;
            this.dataGridView_SP.Size = new System.Drawing.Size(530, 384);
            this.dataGridView_SP.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_SoLuong);
            this.panel2.Controls.Add(this.textBox_Gia);
            this.panel2.Controls.Add(this.textBox_TenSP);
            this.panel2.Controls.Add(this.textBox_MaSP);
            this.panel2.Controls.Add(this.button_ReloadSP);
            this.panel2.Controls.Add(this.button_SuaSP);
            this.panel2.Controls.Add(this.button_XoaSP);
            this.panel2.Controls.Add(this.button_ThemSP);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 384);
            this.panel2.TabIndex = 0;
            // 
            // button_ReloadSP
            // 
            this.button_ReloadSP.Location = new System.Drawing.Point(3, 342);
            this.button_ReloadSP.Name = "button_ReloadSP";
            this.button_ReloadSP.Size = new System.Drawing.Size(75, 39);
            this.button_ReloadSP.TabIndex = 3;
            this.button_ReloadSP.Text = "Reload";
            this.button_ReloadSP.UseVisualStyleBackColor = true;
            // 
            // button_SuaSP
            // 
            this.button_SuaSP.Location = new System.Drawing.Point(3, 252);
            this.button_SuaSP.Name = "button_SuaSP";
            this.button_SuaSP.Size = new System.Drawing.Size(75, 39);
            this.button_SuaSP.TabIndex = 2;
            this.button_SuaSP.Text = "Sửa";
            this.button_SuaSP.UseVisualStyleBackColor = true;
            // 
            // button_XoaSP
            // 
            this.button_XoaSP.Location = new System.Drawing.Point(3, 297);
            this.button_XoaSP.Name = "button_XoaSP";
            this.button_XoaSP.Size = new System.Drawing.Size(75, 39);
            this.button_XoaSP.TabIndex = 1;
            this.button_XoaSP.Text = "Xóa";
            this.button_XoaSP.UseVisualStyleBackColor = true;
            this.button_XoaSP.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_ThemSP
            // 
            this.button_ThemSP.Location = new System.Drawing.Point(3, 207);
            this.button_ThemSP.Name = "button_ThemSP";
            this.button_ThemSP.Size = new System.Drawing.Size(75, 39);
            this.button_ThemSP.TabIndex = 0;
            this.button_ThemSP.Text = "Thêm";
            this.button_ThemSP.UseVisualStyleBackColor = true;
            // 
            // tabPage_DanhMuc
            // 
            this.tabPage_DanhMuc.Controls.Add(this.panel3);
            this.tabPage_DanhMuc.Controls.Add(this.dataGridView_DM);
            this.tabPage_DanhMuc.Location = new System.Drawing.Point(4, 25);
            this.tabPage_DanhMuc.Name = "tabPage_DanhMuc";
            this.tabPage_DanhMuc.Size = new System.Drawing.Size(768, 397);
            this.tabPage_DanhMuc.TabIndex = 2;
            this.tabPage_DanhMuc.Text = "Danh Mục";
            this.tabPage_DanhMuc.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_TenDM);
            this.panel3.Controls.Add(this.textBox_MaDM);
            this.panel3.Controls.Add(this.button_ReloadDM);
            this.panel3.Controls.Add(this.button_SuaDM);
            this.panel3.Controls.Add(this.button_XoaDM);
            this.panel3.Controls.Add(this.button_ThemDM);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 390);
            this.panel3.TabIndex = 1;
            // 
            // button_ReloadDM
            // 
            this.button_ReloadDM.Location = new System.Drawing.Point(3, 347);
            this.button_ReloadDM.Name = "button_ReloadDM";
            this.button_ReloadDM.Size = new System.Drawing.Size(75, 39);
            this.button_ReloadDM.TabIndex = 7;
            this.button_ReloadDM.Text = "Reload";
            this.button_ReloadDM.UseVisualStyleBackColor = true;
            // 
            // button_SuaDM
            // 
            this.button_SuaDM.Location = new System.Drawing.Point(3, 257);
            this.button_SuaDM.Name = "button_SuaDM";
            this.button_SuaDM.Size = new System.Drawing.Size(75, 39);
            this.button_SuaDM.TabIndex = 6;
            this.button_SuaDM.Text = "Sửa";
            this.button_SuaDM.UseVisualStyleBackColor = true;
            // 
            // button_XoaDM
            // 
            this.button_XoaDM.Location = new System.Drawing.Point(3, 302);
            this.button_XoaDM.Name = "button_XoaDM";
            this.button_XoaDM.Size = new System.Drawing.Size(75, 39);
            this.button_XoaDM.TabIndex = 5;
            this.button_XoaDM.Text = "Xóa";
            this.button_XoaDM.UseVisualStyleBackColor = true;
            // 
            // button_ThemDM
            // 
            this.button_ThemDM.Location = new System.Drawing.Point(3, 212);
            this.button_ThemDM.Name = "button_ThemDM";
            this.button_ThemDM.Size = new System.Drawing.Size(75, 39);
            this.button_ThemDM.TabIndex = 4;
            this.button_ThemDM.Text = "Thêm";
            this.button_ThemDM.UseVisualStyleBackColor = true;
            // 
            // dataGridView_DM
            // 
            this.dataGridView_DM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DM.Location = new System.Drawing.Point(210, 4);
            this.dataGridView_DM.Name = "dataGridView_DM";
            this.dataGridView_DM.RowHeadersWidth = 51;
            this.dataGridView_DM.RowTemplate.Height = 24;
            this.dataGridView_DM.Size = new System.Drawing.Size(555, 397);
            this.dataGridView_DM.TabIndex = 0;
            // 
            // tabPage4_TaiKhoan
            // 
            this.tabPage4_TaiKhoan.Controls.Add(this.dataGridView_TK);
            this.tabPage4_TaiKhoan.Controls.Add(this.panel4);
            this.tabPage4_TaiKhoan.Location = new System.Drawing.Point(4, 25);
            this.tabPage4_TaiKhoan.Name = "tabPage4_TaiKhoan";
            this.tabPage4_TaiKhoan.Size = new System.Drawing.Size(768, 397);
            this.tabPage4_TaiKhoan.TabIndex = 3;
            this.tabPage4_TaiKhoan.Text = "Tài Khoản Đăng Nhập";
            this.tabPage4_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TK
            // 
            this.dataGridView_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TK.Location = new System.Drawing.Point(211, 4);
            this.dataGridView_TK.Name = "dataGridView_TK";
            this.dataGridView_TK.RowHeadersWidth = 51;
            this.dataGridView_TK.RowTemplate.Height = 24;
            this.dataGridView_TK.Size = new System.Drawing.Size(554, 390);
            this.dataGridView_TK.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_NgayTao);
            this.panel4.Controls.Add(this.textBox_Loai);
            this.panel4.Controls.Add(this.textBox_Password);
            this.panel4.Controls.Add(this.textBox_Ten);
            this.panel4.Controls.Add(this.textBox_Username);
            this.panel4.Controls.Add(this.button_ReloadTK);
            this.panel4.Controls.Add(this.button_SuaTK);
            this.panel4.Controls.Add(this.button_XoaTK);
            this.panel4.Controls.Add(this.button_ThemTK);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 390);
            this.panel4.TabIndex = 0;
            // 
            // button_ReloadTK
            // 
            this.button_ReloadTK.Location = new System.Drawing.Point(3, 348);
            this.button_ReloadTK.Name = "button_ReloadTK";
            this.button_ReloadTK.Size = new System.Drawing.Size(75, 39);
            this.button_ReloadTK.TabIndex = 7;
            this.button_ReloadTK.Text = "Reload";
            this.button_ReloadTK.UseVisualStyleBackColor = true;
            // 
            // button_SuaTK
            // 
            this.button_SuaTK.Location = new System.Drawing.Point(3, 258);
            this.button_SuaTK.Name = "button_SuaTK";
            this.button_SuaTK.Size = new System.Drawing.Size(75, 39);
            this.button_SuaTK.TabIndex = 6;
            this.button_SuaTK.Text = "Sửa";
            this.button_SuaTK.UseVisualStyleBackColor = true;
            // 
            // button_XoaTK
            // 
            this.button_XoaTK.Location = new System.Drawing.Point(3, 303);
            this.button_XoaTK.Name = "button_XoaTK";
            this.button_XoaTK.Size = new System.Drawing.Size(75, 39);
            this.button_XoaTK.TabIndex = 5;
            this.button_XoaTK.Text = "Xóa";
            this.button_XoaTK.UseVisualStyleBackColor = true;
            // 
            // button_ThemTK
            // 
            this.button_ThemTK.Location = new System.Drawing.Point(3, 213);
            this.button_ThemTK.Name = "button_ThemTK";
            this.button_ThemTK.Size = new System.Drawing.Size(75, 39);
            this.button_ThemTK.TabIndex = 4;
            this.button_ThemTK.Text = "Thêm";
            this.button_ThemTK.UseVisualStyleBackColor = true;
            // 
            // textBox_MaSP
            // 
            this.textBox_MaSP.Location = new System.Drawing.Point(115, 3);
            this.textBox_MaSP.Name = "textBox_MaSP";
            this.textBox_MaSP.Size = new System.Drawing.Size(100, 22);
            this.textBox_MaSP.TabIndex = 4;
            // 
            // textBox_TenSP
            // 
            this.textBox_TenSP.Location = new System.Drawing.Point(115, 31);
            this.textBox_TenSP.Name = "textBox_TenSP";
            this.textBox_TenSP.Size = new System.Drawing.Size(100, 22);
            this.textBox_TenSP.TabIndex = 5;
            // 
            // textBox_Gia
            // 
            this.textBox_Gia.Location = new System.Drawing.Point(115, 59);
            this.textBox_Gia.Name = "textBox_Gia";
            this.textBox_Gia.Size = new System.Drawing.Size(100, 22);
            this.textBox_Gia.TabIndex = 6;
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(115, 87);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(100, 22);
            this.textBox_SoLuong.TabIndex = 7;
            // 
            // textBox_TenDM
            // 
            this.textBox_TenDM.Location = new System.Drawing.Point(97, 31);
            this.textBox_TenDM.Name = "textBox_TenDM";
            this.textBox_TenDM.Size = new System.Drawing.Size(100, 22);
            this.textBox_TenDM.TabIndex = 9;
            // 
            // textBox_MaDM
            // 
            this.textBox_MaDM.Location = new System.Drawing.Point(97, 3);
            this.textBox_MaDM.Name = "textBox_MaDM";
            this.textBox_MaDM.Size = new System.Drawing.Size(100, 22);
            this.textBox_MaDM.TabIndex = 8;
            // 
            // textBox_Loai
            // 
            this.textBox_Loai.Location = new System.Drawing.Point(97, 87);
            this.textBox_Loai.Name = "textBox_Loai";
            this.textBox_Loai.Size = new System.Drawing.Size(100, 22);
            this.textBox_Loai.TabIndex = 11;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(97, 59);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 22);
            this.textBox_Password.TabIndex = 10;
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.Location = new System.Drawing.Point(97, 31);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(100, 22);
            this.textBox_Ten.TabIndex = 9;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(97, 3);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 22);
            this.textBox_Username.TabIndex = 8;
            // 
            // textBox_NgayTao
            // 
            this.textBox_NgayTao.Location = new System.Drawing.Point(97, 115);
            this.textBox_NgayTao.Name = "textBox_NgayTao";
            this.textBox_NgayTao.Size = new System.Drawing.Size(100, 22);
            this.textBox_NgayTao.TabIndex = 12;
            // 
            // dateTimePicker_FromDate
            // 
            this.dateTimePicker_FromDate.Location = new System.Drawing.Point(3, 34);
            this.dateTimePicker_FromDate.Name = "dateTimePicker_FromDate";
            this.dateTimePicker_FromDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_FromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày ...";
            // 
            // dateTimePicker_ToDate
            // 
            this.dateTimePicker_ToDate.Location = new System.Drawing.Point(3, 103);
            this.dateTimePicker_ToDate.Name = "dateTimePicker_ToDate";
            this.dateTimePicker_ToDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_ToDate.TabIndex = 4;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLy";
            this.Text = "Quản Lý";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_DoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_SanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_DanhMuc.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DM)).EndInit();
            this.tabPage4_TaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TK)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_DoanhThu;
        private System.Windows.Forms.TabPage tabPage_SanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage_DanhMuc;
        private System.Windows.Forms.TabPage tabPage4_TaiKhoan;
        private System.Windows.Forms.DataGridView dataGridView_DT;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.DataGridView dataGridView_SP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ReloadSP;
        private System.Windows.Forms.Button button_SuaSP;
        private System.Windows.Forms.Button button_XoaSP;
        private System.Windows.Forms.Button button_ThemSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_DM;
        private System.Windows.Forms.DataGridView dataGridView_TK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_ReloadDM;
        private System.Windows.Forms.Button button_SuaDM;
        private System.Windows.Forms.Button button_XoaDM;
        private System.Windows.Forms.Button button_ThemDM;
        private System.Windows.Forms.Button button_ReloadTK;
        private System.Windows.Forms.Button button_SuaTK;
        private System.Windows.Forms.Button button_XoaTK;
        private System.Windows.Forms.Button button_ThemTK;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.TextBox textBox_Gia;
        private System.Windows.Forms.TextBox textBox_TenSP;
        private System.Windows.Forms.TextBox textBox_MaSP;
        private System.Windows.Forms.TextBox textBox_TenDM;
        private System.Windows.Forms.TextBox textBox_MaDM;
        private System.Windows.Forms.TextBox textBox_Loai;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_NgayTao;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FromDate;
    }
}