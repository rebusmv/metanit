using System;

namespace SportSection.Models
{
    public class Practise
    {
        public int Id { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int GroupId { get; set; }
        public string Description { get; set; }
    }
}
