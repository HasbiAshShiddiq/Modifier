using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifier
{
    class Time
    {
        /*Constructor
        public Time()
        {
            Year = 2019;
            Month = 10;
            Date = 10;
            Hour = 10;
            Minute = 30;
            Second = 40;
        }*/
        //Overload constructor
        public Time(int year, int month, int date, int hour, int minute,
            int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        
        //Private Variables Atau Field
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;
        /*Properties
        public int Year { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }*/
        public int Year {
            get { return year; }
            set { year = value; }
        }
        public int Month {
            get { return month; }
            set { month = value; }
        }
        public int Date {
            get { return date; }
            set { date = value; }
        }
        public int Hour {
            get { return hour; }
            set { hour = value; }
        }
        public int Minute {
            get { return minute; }
            set { minute = value; }
        }
        public int Second {
            get { return second; }
            set { second = value; }
        }

        /*public void DisplayCurrentTime()
        {
            Console.WriteLine("waktu Sekarang : {0}", DateTime.Now.ToString());
        }*/
    }
}
