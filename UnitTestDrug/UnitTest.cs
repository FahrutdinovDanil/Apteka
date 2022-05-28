using Microsoft.VisualStudio.TestTools.UnitTesting;
using Apteka;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestDrug
{
    [TestClass]
    public class UnitTest
    {
        static List<Drug> listDr;
        [ClassInitialize]
        public static void GetDrug(TestContext testContext)
        {
            listDr = new List<Drug>()
            {
                new Drug { Id = 5, Name = "�������", IdManufacturer = 3, Price = 56},
                new Drug { Id = 4, Name = "�������", IdManufacturer = 2, Price = 155},
                new Drug { Id = 1, Name = "�������", IdManufacturer = 1, Price = 490 },
                new Drug { Id = 2, Name = "���������", IdManufacturer = 2, Price = 765 },
                new Drug { Id = 3, Name = "���������", IdManufacturer = 3, Price = 1056 }
            };
        }


        [TestMethod]
        public void TestDrugName()
        {
            List<string> expectedNameDrug = Drug.GetName();

            List<string> actualNameDrug = new List<string>()
            {
                "�������",
                "���������",
                "���������",
                "�������",
                "�������"
            };

            CollectionAssert.AreEqual(expectedNameDrug, actualNameDrug);
        }

        [TestMethod]
        public void TestNameManufacture()
        {
            List<string> expectedNameManufacturer = Drug.GetNameManufacture();

            List<string> actualNameManufacturer = new List<string>()
            {
                "������",
                "������������",
                "�������"
            };

            CollectionAssert.AreEqual(expectedNameManufacturer, actualNameManufacturer);
        }
        [TestMethod]
        public void GetPharmaciesByYear()
        {
            var pharmacist1 = new Pharmacist("aaa", new System.DateTime(2000, 03, 30), 2.5);
            var pharmacist2 = new Pharmacist("bbb", new System.DateTime(2001, 04, 20), 3.7);
            var pharmacist3 = new Pharmacist("ccc", new System.DateTime(1999, 06, 12), 1);
            var pharmacist4 = new Pharmacist("ddd", new System.DateTime(1999, 04, 21), 1.5);
            var pharmacist5 = new Pharmacist("eee", new System.DateTime(1999, 07, 14), 3.1);

            var Employee = new List<Pharmacist> { pharmacist1, pharmacist2, pharmacist3, pharmacist4, pharmacist5 };

            var Waited = new List<Pharmacist> { pharmacist3, pharmacist4, pharmacist5 };

            var pharmacy = new Pharmacy("����������� 26")
            {
                Pharms = Employee
            };

            CollectionAssert.AreEqual(Waited, pharmacy.GetPharmacistsByBirthYear(1999));
        }

        //[TestMethod]
        //public void TestDescOrder()
        //{
        //    List<Drug> actualSortOrderByDrug = new List<Drug>()
        //    {
        //        new Drug { Id = 3, Name = "���������", IdManufacturer = 3, Price = 1056},
        //        new Drug { Id = 2, Name = "���������", IdManufacturer = 2, Price = 765},
        //        new Drug { Id = 1, Name = "�������", IdManufacturer = 1, Price = 490},
        //        new Drug { Id = 4, Name = "�������", IdManufacturer = 2, Price = 155},
        //        new Drug { Id = 5, Name = "�������", IdManufacturer = 3, Price = 56}
        //    };

        //    CollectionAssert.AreEqual(listDr, actualSortOrderByDrug);
        //}

        //[TestMethod]
        //public void TestSortByOrder()
        //{
        //    List<Drug> expectedSortOrderByDrug = Drug.SortByOrder();
        //    List<Drug> actualSortOrderByDrug = Drug.GetDrug().OrderBy(x => x.Price).ToList();

        //    CollectionAssert.AreEqual(expectedSortOrderByDrug, actualSortOrderByDrug);
        //}

        [TestMethod]
        public void TestExpensiveDrug()
        {
            string expectedNameDrug = Drug.ExpensiveDrug();
            string actualNameDrug = "���������";

            Assert.AreEqual(expectedNameDrug, actualNameDrug);
        }

        [TestMethod]
        public void TestGetDrugInPharm()
        {
            List<Drug> actualDrugInPharm = new List<Drug>()
            {
                new Drug { Id = 1, Name = "�������", IdManufacturer = 1, Price = 490},
                new Drug { Id = 2, Name = "���������", IdManufacturer = 2, Price = 765}
            };
            Assert.AreEqual(InStock.GetDrugInPharms(1).Count(), actualDrugInPharm.Count());
        }
    }
}
