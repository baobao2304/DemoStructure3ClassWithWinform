using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001170836_PhamVanLeBao
{
    public partial class Form2 : Form
    {
        private string maghidanh;
        private string v;
        private string gioitinh;
        private string ngaysinh;
        private string email;
        private string dienthoai;
        private string tenmonhoc;
        private string buoi2;
        private bool thixl;
        string thixl1 = "";

        public Form2()
        {
            lbMaGhiDanh.Text = maghidanh;
            lbHoVaTen.Text = v;
            lbGioiTinh.Text = gioitinh;
            lbNgaySinh.Text = ngaysinh;
            lbEmail.Text = email;
            lbDienThoai.Text = dienthoai;
            lbMonHoc.Text = tenmonhoc;
            lbhotenthisinh.Text = v;
            InitializeComponent();
        }

        public Form2(string maghidanh, string v, string gioitinh, string ngaysinh, string email, string dienthoai, string tenmonhoc, string buoi2, bool thixl)
        {
            this.maghidanh = maghidanh;
            this.v = v;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.email = email;
            this.dienthoai = dienthoai;
            this.tenmonhoc = tenmonhoc;
            this.buoi2 = buoi2;
            this.thixl = thixl;
            if (thixl)
            {
               thixl1 = "Đã tham gia thi Online xếp lớp";
            }
            else
            {
               thixl1 = "Chưa tham gia thi Online xếp lớp";
            }
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbMaGhiDanh.Text = maghidanh;
            lbHoVaTen.Text = v;
            lbGioiTinh.Text = gioitinh;
            lbNgaySinh.Text = ngaysinh;
            lbEmail.Text = email;
            lbDienThoai.Text = dienthoai;
            lbMonHoc.Text = tenmonhoc;
            lbhotenthisinh.Text = v;
            InitializeComponent();
        }
    }
}
