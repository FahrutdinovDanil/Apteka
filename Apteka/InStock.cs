using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apteka
{
    public class InStock
    {
        public int IdDrug { get; set; }
        public int IdPharmacy { get; set; }
        public int Count { get; set; }

        public static List<InStock> GetInStock()
        {
            return new List<InStock>()
            {
                new InStock {IdDrug = 3, IdPharmacy = 3, Count = 5 },
                new InStock {IdDrug = 2, IdPharmacy = 2, Count = 15 },
                new InStock {IdDrug = 1, IdPharmacy = 1, Count = 25 },
                new InStock {IdDrug = 2, IdPharmacy = 1, Count = 10 },
                new InStock {IdDrug = 3, IdPharmacy = 2, Count = 45 },
                new InStock {IdDrug = 1, IdPharmacy = 2, Count = 2 },
                new InStock {IdDrug = 3, IdPharmacy = 2, Count = 5 }
            };
        }
        public static List<Drug> GetDrugInPharms(int Id)
        {
            List<Drug> drug = new List<Drug>();
            foreach (var i in GetInStock().Where(a => a.IdPharmacy == Id))
            {
                drug.Add(Drug.GetDrug().Where(a => a.Id == i.IdDrug).FirstOrDefault());
            }
            return drug;
        }
    }
}
