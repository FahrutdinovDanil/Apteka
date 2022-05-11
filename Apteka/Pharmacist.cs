using System;
using System.Collections.Generic;
using System.Text;

namespace Apteka
{
    public class Pharmacist
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Experience { get; set; }

        public List<Pharmacist> GetPharmacists()
        {
            return new List<Pharmacist>()
            {
                new Pharmacist { Id = 1, FullName = "Хайруллин Адель Ильдарович", Experience = 3},
                new Pharmacist { Id = 2, FullName = "Барышев Эмиль Евгеньевич", Experience = 4},
                new Pharmacist { Id = 3, FullName = "Гаврилов Даниил Игоревич", Experience = 5}
            };
        }
    }
}
