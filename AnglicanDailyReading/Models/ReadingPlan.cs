using System.Collections.Generic;

namespace AnglicanDailyReading.Models
{
    public class ReadingPlan
    {
        public string Title { get; set; }
        public List<Daily> Passages { get; set; }

        public ReadingPlan()
        {
            Passages = new List<Daily>();
        }
    }
}
