using System;
using System.Collections.Generic;
using System.Text;

namespace Apteka
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Manufacturer> GetManufacturers()
        {
            return new List<Manufacturer>()
            {
                new Manufacturer() { Id = 0, Name ="Эвалар"},
                new Manufacturer() { Id = 1, Name ="Фармстандарт"},
                new Manufacturer() { Id = 2, Name ="Еаптека"}
            };
        }
    }
}
