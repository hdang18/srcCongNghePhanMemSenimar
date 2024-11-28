using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ_1.Models
{
    public class ChuDeModel
    {
        public List<ChuDe> LayDanhSachChuDe(dbQuanLySachDataContext qlBS)
        {
            List<ChuDe> ds = qlBS.ChuDes.Select(cd => cd).Skip(0).Take(7).OrderBy(cd => cd.TenChuDe).ToList<ChuDe>();
            return ds;
        }
        public List<Sach> LayDanhSachSachTheoChuDe(dbQuanLySachDataContext qlBS, int id)
        {
            List<Sach> dsSach = qlBS.Saches.Where(sa => sa.MaChuDe == id).ToList<Sach>();
            return dsSach;
        }
    }
}