using System;

namespace UserProject.Entity
{
    public class Work
    {
        public int ID { get; set; }
        public string subject { get; set; }
        public string DESCRIPTION { get; set; }
        public string type { get; set; }
        public byte  emergency { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string note {get; set;}
    }
}