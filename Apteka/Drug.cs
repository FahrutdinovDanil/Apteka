using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apteka
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdManufacturer { get; set; }
        public double Price { get; set; }

        public static List<Drug> GetDrug()
        {
            return new List<Drug>()
            {
                new Drug { Id = 1, Name = "Нурофен", IdManufacturer = 1, Price = 490},
                new Drug { Id = 2, Name = "Детралекс", IdManufacturer = 2, Price = 765},
                new Drug { Id = 3, Name = "Пенталгин", IdManufacturer = 3, Price = 1056},
                new Drug { Id = 4, Name = "Кагоцел", IdManufacturer = 2, Price = 655},
                new Drug { Id = 5, Name = "Терафлю", IdManufacturer = 3, Price = 467}
            };
        }

        public static List<string> GetName()
        {
            List<string> DrugName = new List<string>();
            foreach (var i in GetDrug())
                DrugName.Add(i.Name);
            return DrugName;
        }

        public static List<string> GetNameManufacture()
        {
            List<string> ManufactureName = new List<string>();
            foreach (var i in Manufacturer.GetManufacturers())
                ManufactureName.Add(i.Name);
            return ManufactureName;
        }

        public static List<Drug> SortByOrder()
        {
            return GetDrug().OrderBy(a => a.Price).ToList();
        }

        public static List<Drug> SortDescOrder()
        {
            return GetDrug().OrderByDescending(a => a.Price).ToList();
        }

        public static string ExpensiveDrug()
        {
            var expensive = GetDrug().OrderByDescending(a => a.Price).ToList();
            return expensive[0].Name;
        }
    }
}
