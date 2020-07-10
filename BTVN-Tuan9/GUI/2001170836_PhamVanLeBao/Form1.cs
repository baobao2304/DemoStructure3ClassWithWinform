using BLL_DAL;
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
    public partial class Form1 : Form
    {
        BLL_DAL_MONHOC qlMonHoc = new BLL_DAL_MONHOC();
        BLL_DAL_GHIDANH qlGhiDanh = new BLL_DAL_GHIDANH();
        public Form1()
        {
            InitializeComponent();
            LoadMonHoc();
        }
        public void LoadMonHoc()
        {
            listBoxMonHoc.DataSource = qlMonHoc.loadMonHoc();
            listBoxMonHoc.DisplayMember = "tenMonHoc";
            listBoxMonHoc.ValueMember = "maMonHoc";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maghidanh = tbMaGhiDanh1.Text;

            string hovachulot = tbHoVaChuLot1.Text;
            string ten = tbTen1.Text;

            string ngaysinh = tbNgaySinh1.Text;

            string email = tbEmail1.Text;

            string dienthoai = tbSoDienThoai1.Text;

            string mamonhoc = listBoxMonHoc.SelectedValue.ToString();
            string tenmonhoc = listBoxMonHoc.SelectedItem.ToString();

            bool thixl = checkboxDaThamGiaThiOnl.Checked;

            var gioitinh = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();

            var buoi2 = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            var buoi1 = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
            int buoi = int.Parse(buoi1);
            if(string.IsNullOrEmpty(maghidanh) || string.IsNullOrEmpty(hovachulot) ||
               string.IsNullOrEmpty(ngaysinh) || string.IsNullOrEmpty(ten) || 
               string.IsNullOrEmpty(gioitinh) || string.IsNullOrEmpty(mamonhoc))
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ ");
                return;
            }
            else
            {
                qlGhiDanh.GhiDanh(maghidanh, hovachulot, ten, ngaysinh, email, dienthoai, mamonhoc, gioitinh, buoi, thixl);
                Program.InfoForm = new Form2(maghidanh, hovachulot + " " + ten,
                                                 gioitinh, ngaysinh, email, dienthoai,
                                                 tenmonhoc, buoi2, thixl);
               Program.InfoForm.Show();
            }    
        }

        private void listBoxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenmonhoc = listBoxMonHoc.SelectedItem.ToString();
            MessageBox.Show(tenmonhoc);
        }
    }
}
