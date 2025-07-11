using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace solv__assignmant_2_oop
{
    //Develop a Class to represent the Hiring Date Data:
   // consisting of fields to hold the day, month and Years.


    internal class HiringDate
    {
        public HiringDate() { }
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }
    }
}
