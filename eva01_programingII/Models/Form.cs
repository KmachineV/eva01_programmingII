using System;
using System.Collections.Generic;
using System.Text;

namespace eva01_programingII.Models
{
    class Form
    {
        public static double getHours(double entryHour, double exitHour)
        {
            int hoursWork = 0;
            for(double i = entryHour; i<exitHour; i++)
            {
                hoursWork++;
            }
            return hoursWork;
        }

        public static int getPresentDays(char[] present)
        {
            int daysPresent = 0;
            
            for(int i = 0; i < present.Length; i++)
            {
                if (present[i] == 'P')
                {
                    daysPresent++;
                }
            }
           return daysPresent;
        }

        public static int getWeeklySalary(int salaryDay, int presentDay)
        {
            return salaryDay * presentDay;
        }

     
        
    }
}

