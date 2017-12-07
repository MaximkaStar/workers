using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersLibary
{
    class Employee
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int payment_build {get; set;}
        public DateTime adoptionDate { get; set; }
        public DateTime? rifDate { get; set; }
    }
}
