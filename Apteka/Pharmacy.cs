using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apteka
{
    public class Pharmacy
    {
        public List<Pharmacist> Pharms;

        public int Id { get; set; }
        public string Address { get; set; }

        public Dictionary<Drug, int> Drugs { get; set; }

        public Pharmacy(string address) : base()
        {
            Address = address;
        }
        public List<Pharmacist> GetPharmacistsByBirthYear(int year)
        {
            return Pharms.Where(x => x.Birthday.Year == year).ToList();
        }
    }
}
