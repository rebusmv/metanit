using System;
using System.Collections.Generic;

namespace SportSection.Models
{
    public class Trainer : Person
    {
        public List<int> KindsOfSport { get; set; }
        public List<int> GroupsId { get; set; }
        public DateTime? StartInCompany { get; set; }
        public DateTime? EndInCompany { get; set; }
        public List<Practise> Practises { get; set; }

    }
}
