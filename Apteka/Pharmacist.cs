using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Apteka
{
    public class Pharmacist
    {
        List<Pharmacist> Pharm = new List<Pharmacist>();
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public double Exp { get; set; }

        public Pharmacist(string fullName, DateTime date, double exp)
        {
            FullName = fullName;
            Birthday = date;
            Exp = exp;
        }
    }
}
