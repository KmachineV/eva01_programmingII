using System;
using System.Collections.Generic;
using System.Text;

namespace eva01_programingII.Models
{
    class Employee
    {
        private string name;
        private string email;
        private string city;
        private string country;
        private string jobTitle;
        private bool workHouse;
        private int dailySalary;
        private double[] schedule;
        private char[] weeklyAttendance;
        private int presentDays;
        private int weeklySalary;
        

        public Employee()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public bool WorkHouse { get => workHouse; set => workHouse = value; }
        public int DailySalary { get => dailySalary; set => dailySalary = value; }
        public double[] Schedule { get => schedule; set => schedule = value; }
        public char[] WeeklyAttendance { get => weeklyAttendance; set => weeklyAttendance = value; }
        public int PresentDays { get => presentDays; set => presentDays = value; }
        public int WeeklySalary { get => weeklySalary; set => weeklySalary = value; }

        public override string ToString()
        {
            return "Nombre: " + Name +
                   "Email: " + Email +
                   "Ciudad : " + City +
                   "Pais: " + Country +
                   "Cargo :" + JobTitle +
                   "Teletrabajo: " + (workHouse.Equals(true) ?  "Teletrabajo" : "Presencial") +
                   "Salario Diario: " + DailySalary;
        }

    }
}
