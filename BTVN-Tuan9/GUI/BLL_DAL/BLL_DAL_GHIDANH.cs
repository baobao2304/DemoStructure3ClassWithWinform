using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class BLL_DAL_GHIDANH
    {
        QLGHIDANHDataContext ql;
        public BLL_DAL_GHIDANH()
        {
            ql = new QLGHIDANHDataContext();
        }
        public IQueryable<GhiDanh> loadGhiDanh()
        {
            return from gd in ql.GhiDanhs select gd;
        }
        public void GhiDanh(string maghidanh,string hovachulot,string ten,
                            string ngaysinh,string email,string dienthoai,
                            string mamonhoc, string gioitinh,int buoi,bool thixl)
        {
            GhiDanh ghiDanh = ql.GhiDanhs.Where(m => m.maGhiDanh.Equals(maghidanh)).FirstOrDefault();
            if(ghiDanh == null)
            {
                GhiDanh gd = new GhiDanh();
                gd.maGhiDanh = maghidanh;
                gd.hoVaTen = hovachulot + " " + ten;
                gd.ngaySinh = DateTime.Parse(ngaysinh);
                gd.gioiTinh = gioitinh;
                gd.dienThoai = dienthoai;
                gd.email = email;
                gd.maMonHoc = mamonhoc;
                gd.buoiHoc = buoi;
                gd.thiXepLop = thixl;
                ql.GhiDanhs.InsertOnSubmit(gd);
                ql.SubmitChanges();
                MessageBox.Show("Đã Lưu Vào Cơ Sở Dữ Liệu");
            }
            else
            {
                MessageBox.Show("Dữ liệu này đã được lưu vào cơ sở dữ liệu với cái tên : "+hovachulot+" "+ten);
                return;
            }    
        }
    }
}
