﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangDienThoai.Forms
{
    public partial class fBill : Form
    {
        QLDTDataContext q;
        public fBill()
        {
            InitializeComponent();

        }
        string maHD;

        public fBill(string maHD, string user, string mk)
        {
            InitializeComponent();
            q = new QLDTDataContext(new ConnectionSQL(user, mk).ConnString());
            this.maHD = maHD;
            lb_maHD.Text = maHD;
            var query = (from item in q.HOADONs
                         where item.maHD.ToString() == maHD
                         select item).SingleOrDefault();

            lb_ngayTaoHD.Text = query.ngayTao.ToString();
            lb_user.Text = query.tenNV;
            txtbox_TenKH.Text = query.tenKH;
            txtbox_SDT.Text = query.sdt;

            var queryhdct = from item in q.HOADONCHITIETs
                            join item2 in q.SANPHAMs on item.maSP equals item2.maSP
                            where item.maHD.ToString() == maHD
                            select new
                            {
                                tenSP = item2.tenSP,
                                giaSP = item2.gia,
                                sl = item.soLuong,
                                thanhtien = item2.gia * item.soLuong
                            };

            dataGridView1.DataSource = queryhdct;
            dataGridView1.RowHeadersVisible = false;

            lb_TongTien.Text = q.TongTienHD(int.Parse(maHD)).ToString();
            query.tongTien = Convert.ToInt32(q.TongTienHD(int.Parse(maHD)));
            q.SubmitChanges();
        }

        private void txtbox_TenKH_TextChanged(object sender, EventArgs e)
        {
            var query = (from item in q.HOADONs
                         where item.maHD.ToString() == lb_maHD.Text
                         select item).SingleOrDefault();
            if (query != null)
            {
                query.tenKH = txtbox_TenKH.Text;
                q.SubmitChanges();
            }
        }

        private void txtbox_SDT_TextChanged(object sender, EventArgs e)
        {
            var query = (from item in q.HOADONs
                         where item.maHD.ToString() == lb_maHD.Text
                         select item).SingleOrDefault();
            if (query != null)
            {
                query.sdt = txtbox_SDT.Text;
                q.SubmitChanges();
            }
        }

        private void btn_XuatHoaDon_Click(object sender, EventArgs e)
        {
           
            q.update_status(int.Parse(maHD));
            XuatBill f = new XuatBill(maHD);
            f.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fBill_Load(object sender, EventArgs e)
        {

        }
    }
}
