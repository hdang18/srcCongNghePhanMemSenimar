using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LINQ_1.Models;

namespace LINQ_1.Controllers
{
    public class SachController : Controller
    {
        dbQuanLySachDataContext qlBS = new dbQuanLySachDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DanhSachSach()
        {
            SachModel obj = new SachModel();
            List<Sach> dsSach = obj.LayDanhSachSach(qlBS);
            return View(dsSach);
        }

        public ActionResult XemChiTiet(int id)
        {
            SachModel obj = new SachModel();
            Sach item = obj.LaySachTheoMa(qlBS, id);
            return View(item);
        }
    }
}