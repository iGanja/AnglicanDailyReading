using System;

namespace AnglicanDailyReading.Models
{
    public class HolyDays
    {
        public int Year { get; set; }
        public DateOnly AshWednesday { get; set; }
        public DateOnly MaundyThursday { get; set; }
        public DateOnly GoodFriday { get; set; }
        public DateOnly HolySaturday { get; set; }
        public DateOnly EasterSunday { get; set; }
        public DateOnly Ascension { get; set; }
        public DateOnly Pentecost { get; set; }
    }
}
