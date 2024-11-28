using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ_1.Models
{
    public class NhaXuatBanModel
    {
        public List<NhaXuatBan> LayDanhSachNXB(dbQuanLySachDataContext qlBS)
        {
            List<NhaXuatBan> ds = qlBS.NhaXuatBans.Select(nxb => nxb).Skip(0).Take(7).OrderBy(nxb => nxb.TenNXB).ToList<NhaXuatBan>();
            return ds;
        }
        public List<Sach> LayDanhSachSachTheoNXB(dbQuanLySachDataContext qlBS,int id)
        {
            List<Sach> dsSach = qlBS.Saches.Where(sa => sa.MaNXB == id).ToList<Sach>();
            return dsSach;
        }
    }
}