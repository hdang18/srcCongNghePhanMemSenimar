using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LINQ_1.Models;

namespace LINQ_1.Controllers
{
    public class ChuDeController : Controller
    {
        dbQuanLySachDataContext qlBS = new dbQuanLySachDataContext();
        // GET: ChuDe
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChuDePartial()
        {
            ChuDeModel obj = new ChuDeModel();
            List<ChuDe> dsTop7 = obj.LayDanhSachChuDe(qlBS);
            return View(dsTop7);
        }
        public ActionResult DSSTheoChuDe(int id)
        {
            ChuDeModel obj = new ChuDeModel();
            List<Sach> dsSach = obj.LayDanhSachSachTheoChuDe(qlBS, id);
            return View("~/Views/Sach/DanhSachSach.cshtml", dsSach);
        }
    }
}