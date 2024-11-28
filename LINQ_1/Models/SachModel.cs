using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ_1.Models
{
    public class SachModel
    {
        public List<Sach> LayDanhSachSach(dbQuanLySachDataContext qlBS)
        {
            List<Sach> ds = qlBS.Saches.Select(sa => sa).ToList<Sach>();
            return ds;
        }
        public Sach LaySachTheoMa(dbQuanLySachDataContext qlBS, int id)
        {
            return qlBS.Saches.FirstOrDefault(sa => sa.MaSach == id);
        }
    }
}