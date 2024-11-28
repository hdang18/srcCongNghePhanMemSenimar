using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LINQ_1.Models
{
    public class GioHang
    {
        dbQuanLySachDataContext db = new dbQuanLySachDataContext();
        private int maSach;
        private string tenSach;
        private string anhBia;
        private double donGia;
        private int soLuong;

        public int MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string AnhBia { get => anhBia; set => anhBia = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double ThanhTien { get => soLuong * donGia; }
        public GioHang(int MaSach)
        {
            this.MaSach = MaSach;
            Sach sach = db.Saches.Single(t => t.MaSach == this.MaSach);
            this.TenSach = sach.TenSach;
            this.AnhBia = sach.AnhBia;
            this.DonGia = double.Parse(sach.GiaBan.ToString());
            this.soLuong = 1;
        }
    }
}