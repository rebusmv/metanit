using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSection.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string IIN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public List<Person> Parents { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
