using System;
using System.Collections.Generic;

namespace SportSection.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> TrainersId { get; set; }
        public List<int> AthletesId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool State { get; set; }
    }
}
