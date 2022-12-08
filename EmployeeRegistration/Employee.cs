using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeRegistration
{
   public class Employee
    {
        public string FirstName;
        public string LastName;
        public int NumberOfHourWorked;
        public double Wage;
        public double HourlyRate;


        public Employee(string first ,string last ,double rate)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;

        }

        public int PerformWork(int hours)
        {
            NumberOfHourWorked += hours;

            return NumberOfHourWorked;
        }
       
        public double ReceiveWage(out int hourWorked)
        {
            Wage = NumberOfHourWorked * HourlyRate;
            Console.WriteLine($"The wage for  { NumberOfHourWorked} hours of work is {Wage} .");
            NumberOfHourWorked = 0;
            hourWorked = NumberOfHourWorked;
            return Wage;
        }
    }
}
