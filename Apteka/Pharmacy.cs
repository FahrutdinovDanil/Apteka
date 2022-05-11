using System;
using System.Collections.Generic;
using System.Text;

namespace Apteka
{
    public class Pharmacy
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public List<Pharmacy> GetPharmacies()
        {
            return new List<Pharmacy>()
            {
                new Pharmacy { Id = 1, Address = "Московская 48"},
                new Pharmacy { Id = 2, Address = "Николая Ершова 78"},
                new Pharmacy { Id = 3, Address = "Космонавтов 26"}
            };
        }
    }
}
