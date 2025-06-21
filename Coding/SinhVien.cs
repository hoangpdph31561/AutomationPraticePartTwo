using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public class SinhVien
    {
        private string maSinhVien;
        private string ten;
        private int tuoi;
        private double diemTrungBinh;
        private int kyHoc;
        private string chuyenNganh;
        public SinhVien()
        {
            
        }

        public SinhVien(string maSinhVien, string ten, int tuoi, double diemTrungBinh, int kyHoc, string chuyenNganh)
        {
            this.maSinhVien = maSinhVien;
            this.ten = ten;
            this.tuoi = tuoi;
            this.diemTrungBinh = diemTrungBinh;
            this.kyHoc = kyHoc;
            this.chuyenNganh = chuyenNganh;
        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double DiemTrungBinh { get => diemTrungBinh; set => diemTrungBinh = value; }
        public int KyHoc { get => kyHoc; set => kyHoc = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
    }
}
