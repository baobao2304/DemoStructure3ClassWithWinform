using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    
    public class BLL_DAL_MONHOC
    {
        QLGHIDANHDataContext ql;
        public BLL_DAL_MONHOC()
        {
            ql = new QLGHIDANHDataContext();
        }
        public IQueryable<MonHoc> loadMonHoc()
        {
            return  ql.MonHocs.Select(m=>m);
        }
    }
}
