using Coding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestUpdate
    {
        SinhVienService sinhVienService;
        [SetUp]
        public void SetUp()
        {
            sinhVienService = new SinhVienService();
        }
        [Test]
        public void TestUpdateZero()
        {
            Assert.IsFalse(sinhVienService.Update(new SinhVien("0", "1", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateOne()
        {
            Assert.IsTrue(sinhVienService.Update(new SinhVien("1", "Hoàng", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateFour()
        {
            Assert.IsTrue(sinhVienService.Update(new SinhVien("4", "Hoàng", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateFive()
        {
            Assert.IsFalse(sinhVienService.Update(new SinhVien("5", "Hoàng", 1, 1, 1, "1")));
        }
        [Test]
        public void TestUpdateNotExistTen()
        {
            Assert.IsFalse(sinhVienService.Update(new SinhVien("2", null, 1, 1, 1, "1")));
        }
    }
}
