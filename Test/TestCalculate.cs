﻿using Coding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestCalculate
    {
        Calculate calculate;
        List<int> lstInt;
        [SetUp]
        public void SetUp()
        {
            calculate = new Calculate();
            lstInt = calculate.GetNumber();
        }
        //Tính tổng 000000, 0 -1 1, -1 -1 -1, 111, 1234
        [Test]
        public void TestZero()
        {
            Assert.AreEqual(0, calculate.Sum([0, 0, 0, 0]));
        }
        [Test]
        public void TestResultZero()
        {
            Assert.AreEqual(0, calculate.Sum([0, 0, 1, -1]));
        }
        [Test]
        public void TestNegative()
        {
            Assert.AreEqual(-3, calculate.Sum([0, -1, -1, -1]));
        }
        [Test]
        public void TestPositive()
        {
            Assert.AreEqual(3, calculate.Sum([0, 1, 1, 1]));
        }
        [Test]
        public void TestNormal()
        {
            Assert.AreEqual(10, calculate.Sum([1, 2, 3, 4]));
        }

        //Kiểm tra số lẻ hay không
        // 0 -1 1 2 3
        [Test]
        public void TestSoLeNegative()
        {
            Assert.IsFalse(calculate.CheckSoLe(-1));
        }
        [Test]
        public void TestSoLeZero()
        {
            Assert.IsFalse(calculate.CheckSoLe(0));
        }
        [Test]
        public void TestSoLeOne()
        {
            Assert.IsTrue(calculate.CheckSoLe(1));
        }
        [Test]
        public void TestSoLeTwo()
        {
            Assert.IsFalse(calculate.CheckSoLe(2));
        }
        [Test]
        public void TestSoLeThree()
        {
            Assert.IsTrue(calculate.CheckSoLe(3));
        }
        // Test các số chia hết cho 5
        //Kiểm tra có tồn tại số 0, 1 , 99, 100, 101
        [Test]
        public void TestExistZero()
        {
            Assert.IsFalse(lstInt.Contains(0));
        }
        [Test]
        public void TestExistOne()
        {
            Assert.IsTrue(lstInt.Contains(1));
        }
        [Test]
        public void TestExistnineNine()
        {
            Assert.IsTrue(lstInt.Contains(99));
        }
        [Test]
        public void TestExistOneHun()
        {
            Assert.IsFalse(lstInt.Contains(100));
        }
        [Test]
        public void TestExistOneOne()
        {
            Assert.IsFalse(lstInt.Contains(101));
        }
    }
}
