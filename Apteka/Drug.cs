using System;
using System.Collections.Generic;
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
   
    }
}
