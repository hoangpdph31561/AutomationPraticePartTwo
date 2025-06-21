using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public class SinhVienService
    {
        List<SinhVien> lstSinhVien;
        public SinhVienService()
        {
            lstSinhVien = new List<SinhVien>()
            {
                new SinhVien("1", "1", 1, 1, 1, "1"),
                new SinhVien("2", "1", 1, 1, 1, "1"),
                new SinhVien("3", "1", 1, 1, 1, "1"),
                new SinhVien("4", "1", 1, 1, 1, "1"),
            };
        }
        public bool Update(SinhVien sinhVien)
        {
            if(!CheckValidate(sinhVien)) return false;
            int index = lstSinhVien.FindIndex(x => x.MaSinhVien == sinhVien.MaSinhVien);
            if (index < 0)
            {
                return false;
            }
            lstSinhVien[index] = sinhVien;
            return true;
        }
        public bool CheckValidate(SinhVien sinhVien)
        {
            return !string.IsNullOrEmpty(sinhVien.MaSinhVien) && !string.IsNullOrEmpty(sinhVien.Ten) && sinhVien.Tuoi > 0 && sinhVien.DiemTrungBinh > 0 && sinhVien.KyHoc > 0 && !string.IsNullOrEmpty(sinhVien.ChuyenNganh);
        }
    }
}
