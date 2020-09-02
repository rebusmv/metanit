using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SportSection.Models
{
    public class Athlete:Person
    {
        public List<int> KindsOfSportId { get; set; }
        public List<Person> Trainers { get; set; }
        public List<int> GroupsId { get; set; }
        public State StateId { get; set; }
        public List<Practise> Practises { get; set; }
    }
}
