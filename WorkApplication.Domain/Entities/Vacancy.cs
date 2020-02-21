using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkApplication.Domain.Entities
{
    public class Vacancy
    {
        public int VacancyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }

    }
}
