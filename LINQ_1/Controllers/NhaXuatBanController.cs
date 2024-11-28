using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LINQ_1.Models;

namespace LINQ_1.Controllers
{
    public class NhaXuatBanController : Controller
    {
        dbQuanLySachDataContext qlBS = new dbQuanLySachDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NhaXuatBanPartial()
        {
            NhaXuatBanModel obj = new NhaXuatBanModel();
            List<NhaXuatBan> dsTop7 = obj.LayDanhSachNXB(qlBS);
            return View(dsTop7);
        }
        public ActionResult DSSTheoNXB(int id)
        {
            NhaXuatBanModel obj = new NhaXuatBanModel();
            List<Sach> dsSach = obj.LayDanhSachSachTheoNXB(qlBS, id);
            return View("~/Views/Sach/DanhSachSach.cshtml", dsSach);
        }
    }
}