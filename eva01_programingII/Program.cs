using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eva01_programingII.Models;

namespace eva01_programingII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var Cant GMAIL
            int cantEmail = 0;
            int cantFromChile = 0;

            //Instances
            Employee person1 = new Employee();
            Employee person2 = new Employee();
            Employee person3 = new Employee();
            Employee person4 = new Employee();
            Employee person5 = new Employee();
            Employee person6 = new Employee();
            Employee person7 = new Employee();
            Employee person8 = new Employee();
            Employee person9 = new Employee();
            Employee person10 = new Employee();

            //schedule list for employees 

            List<double> timetable1 = new List<double> { 8.3, 18.00 };
            List<double> timetable2 = new List<double> { 9.30, 18.30 };
            List<double> timetable3 = new List<double> { 8.30, 18.00 };
            List<double> timetable4 = new List<double> { 10.30, 20.00 };
            List<double> timetable5 = new List<double> { 9.00, 16.00 };
            List<double> timetable6 = new List<double> { 12.30, 14.30 };
            List<double> timetable7 = new List<double> { 8.30, 14.30 };
            List<double> timetable8 = new List<double> { 8.30, 18.00 };
            List<double> timetable9 = new List<double> { 8.30, 18.00 };
            List<double> timetable10 = new List<double> { 8.30, 18.00 };

            //Agg timetable a the list

            timetable1.Add(Form.getHours(timetable1[0], timetable1[1]));
            timetable2.Add(Form.getHours(timetable2[0], timetable2[1]));
            timetable3.Add(Form.getHours(timetable3[0], timetable3[1]));
            timetable4.Add(Form.getHours(timetable4[0], timetable4[1]));
            timetable5.Add(Form.getHours(timetable5[0], timetable5[1]));
            timetable6.Add(Form.getHours(timetable6[0], timetable6[1]));
            timetable7.Add(Form.getHours(timetable7[0], timetable7[1]));
            timetable8.Add(Form.getHours(timetable8[0], timetable8[1]));
            timetable9.Add(Form.getHours(timetable9[0], timetable9[1]));
            timetable10.Add(Form.getHours(timetable10[0],timetable10[1]));



            //List assitenc  
            List<char> assitenc1 = new List<char> { 'P', 'P', 'P', 'P', 'P', 'A', 'A' };
            List<char> assitenc2 = new List<char> { 'A', 'P', 'A', 'A', 'P', 'A', 'A' };
            List<char> assitenc3 = new List<char> { 'P', 'A', 'A', 'P', 'A', 'P', 'P' };
            List<char> assitenc4 = new List<char> { 'P', 'P', 'P', 'P', 'P', 'P', 'P' };
            List<char> assitenc5 = new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'A' };
            List<char> assitenc6 = new List<char> { 'A', 'P', 'P', 'A', 'P', 'A', 'A' };
            List<char> assitenc7 = new List<char> { 'A', 'P', 'P', 'P', 'P', 'A', 'A' };
            List<char> assitenc8 = new List<char> { 'P', 'P', 'P', 'P', 'P', 'A', 'A' };
            List<char> assitenc9 = new List<char> { 'P', 'P', 'P', 'P', 'P', 'A', 'A' };
            List<char> assitenc10 = new List<char> { 'P', 'P', 'P', 'P', 'P', 'A', 'A' };


            //populating  instances

            person1.Name = "Pedro"; person1.Email = "pedro@gmail.com"; person1.City = "Santiago"; person1.Country = "Chile"; person1.JobTitle = "Gerente";
            person1.WorkHouse = false; person1.DailySalary = 20000; person1.Schedule = timetable1.ToArray(); person1.WeeklyAttendance = assitenc1.ToArray();
            person1.PresentDays = Form.getPresentDays(person1.WeeklyAttendance); person1.WeeklySalary = Form.getWeeklySalary(person1.DailySalary, person1.PresentDays);

            person2.Name = "Luis"; person2.Email = "luis@hotmail.com"; person2.City = "Bogota"; person2.Country = "Colombia"; person2.JobTitle = "Supervisor";
            person2.WorkHouse = true; person2.DailySalary = 15000; person2.Schedule = timetable2.ToArray(); person2.WeeklyAttendance = assitenc2.ToArray();
            person2.PresentDays = Form.getPresentDays(person2.WeeklyAttendance); person2.WeeklySalary = Form.getWeeklySalary(person2.DailySalary, person2.PresentDays);

            person3.Name = "Carlos"; person3.Email = "carlos@gmail.com"; person3.City = "Caracas"; person3.Country = "Venezuela"; person3.JobTitle = "Gerente";
            person3.WorkHouse = false; person3.DailySalary = 18000; person3.Schedule = timetable3.ToArray(); person3.WeeklyAttendance = assitenc3.ToArray();
            person3.PresentDays = Form.getPresentDays(person3.WeeklyAttendance); person3.WeeklySalary = Form.getWeeklySalary(person3.DailySalary, person3.PresentDays);

            person4.Name = "Jhon"; person4.Email = "jhon@yahoo.com"; person4.City = "Lima"; person4.Country = "Peru"; person4.JobTitle = "Ayudante";
            person4.WorkHouse = true; person4.DailySalary = 15000; person4.Schedule = timetable4.ToArray(); person4.WeeklyAttendance = assitenc4.ToArray();
            person4.PresentDays = Form.getPresentDays(person4.WeeklyAttendance); person4.WeeklySalary = Form.getWeeklySalary(person4.DailySalary, person4.PresentDays);

            person5.Name = "Raul"; person5.Email = "raul@gmail.com"; person5.City = "Sao Paulo"; person5.Country = "Brazil"; person5.JobTitle = "Asistente";
            person5.WorkHouse = true; person5.DailySalary = 16000; person5.Schedule = timetable5.ToArray(); person5.WeeklyAttendance = assitenc5.ToArray();
            person5.PresentDays = Form.getPresentDays(person5.WeeklyAttendance); person5.WeeklySalary = Form.getWeeklySalary(person5.DailySalary, person5.PresentDays);

            person6.Name = "Diego"; person6.Email = "diego@gmail.com"; person6.City = "Ciudad de Mexico"; person6.Country = "Mexico"; person6.JobTitle = "Encargado";
            person6.WorkHouse = true; person6.DailySalary = 21000; person6.Schedule = timetable6.ToArray(); person6.WeeklyAttendance = assitenc6.ToArray();
            person6.PresentDays = Form.getPresentDays(person6.WeeklyAttendance); person6.WeeklySalary = Form.getWeeklySalary(person6.DailySalary, person6.PresentDays);

            person7.Name = "Saul"; person7.Email = "saul@outlook.com"; person7.City = "Santiago"; person7.Country = "Chile"; person7.JobTitle = "Seguridad";
            person7.WorkHouse = false; person7.DailySalary = 13000; person7.Schedule = timetable7.ToArray(); person7.WeeklyAttendance = assitenc7.ToArray();
            person7.PresentDays = Form.getPresentDays(person7.WeeklyAttendance); person7.WeeklySalary = Form.getWeeklySalary(person7.DailySalary, person7.PresentDays);

            person8.Name = "Jhonny"; person8.Email = "jhonny@gmail.com"; person8.City = "Valparaiso"; person8.Country = "Chile"; person8.JobTitle = "Presidente";
            person8.WorkHouse = false; person8.DailySalary = 50000; person8.Schedule = timetable8.ToArray(); person8.WeeklyAttendance = assitenc8.ToArray();
            person8.PresentDays = Form.getPresentDays(person8.WeeklyAttendance); person8.WeeklySalary = Form.getWeeklySalary(person8.DailySalary, person8.PresentDays);

            person9.Name = "Orlando"; person9.Email = "orlando@gmail.com"; person9.City = "Santiago"; person9.Country = "Chile"; person9.JobTitle = "Gerente";
            person9.WorkHouse = false; person9.DailySalary = 20000; person9.Schedule = timetable9.ToArray(); person9.WeeklyAttendance = assitenc9.ToArray();
            person9.PresentDays = Form.getPresentDays(person9.WeeklyAttendance); person9.WeeklySalary = Form.getWeeklySalary(person9.DailySalary, person9.PresentDays);

            person10.Name = "Stuart"; person10.Email = "stuart@gmail.com"; person10.City = "Santiago"; person10.Country = "Chile"; person10.JobTitle = "Gerente";
            person10.WorkHouse = false; person10.DailySalary = 20000; person10.Schedule = timetable10.ToArray(); person10.WeeklyAttendance = assitenc10.ToArray();
            person10.PresentDays = Form.getPresentDays(person10.WeeklyAttendance); person10.WeeklySalary = Form.getWeeklySalary(person10.DailySalary, person10.PresentDays);

            //list the instances
            List<Employee> workPerson = new List<Employee>
            {
                   person1, person2, person3, person4, person5,
                   person6, person7, person8, person9,person10
            };
            foreach (Employee listWorkPerson in workPerson)

            {
                Console.WriteLine("\n::::::::Data::::::::\n");
                Console.WriteLine("Nombre trabajador : " + listWorkPerson.Name);
                Console.WriteLine("Email del trabajador : " + listWorkPerson.Email);
                Console.WriteLine("Ciudad : " + listWorkPerson.City);
                Console.WriteLine("Pais : " + listWorkPerson.Country);
                Console.WriteLine("Cargo : " + listWorkPerson.JobTitle);
                Console.WriteLine("Trabaja desde casa: " + listWorkPerson.WorkHouse);
                Console.WriteLine("Salario diario: " + listWorkPerson.DailySalary);
                Console.WriteLine("Horario de entrada: " + listWorkPerson.Schedule[0]+ "Hours");
                Console.WriteLine("Horario de Salida: " + listWorkPerson.Schedule[1] + "Hours");


                Console.WriteLine("\nAsistencia Semanal - LUNES: " + listWorkPerson.WeeklyAttendance[0]);
                Console.WriteLine("\nAsistencia Semanal - MARTES: " + listWorkPerson.WeeklyAttendance[1]);
                Console.WriteLine("\nAsistencia Semanal - MIERCOLES: " + listWorkPerson.WeeklyAttendance[2]);
                Console.WriteLine("\nAsistencia Semanal - JUEVES: " + listWorkPerson.WeeklyAttendance[3]);
                Console.WriteLine("\nAsistencia Semanal - VIERNES: " + listWorkPerson.WeeklyAttendance[4]);
                Console.WriteLine("\nAsistencia Semanal - SABADO: " + listWorkPerson.WeeklyAttendance[5]);
                Console.WriteLine("\nAsistencia Semanal - DOMINGO: " + listWorkPerson.WeeklyAttendance[6]);
                Console.WriteLine("\nDias Presentes: " + listWorkPerson.PresentDays);
                Console.WriteLine("\nSueldo Semanal segun asistencia: " + listWorkPerson.WeeklySalary);
                
            }
            List<int> promiseSalary = new List<int>
            {
                   person1.DailySalary, person2.DailySalary, person3.DailySalary, person4.DailySalary, person5.DailySalary,
                   person6.DailySalary, person7.DailySalary, person8.DailySalary, person9.DailySalary,person10.DailySalary
            };

           
            Console.WriteLine("\n___________________Statistics ________________________");
            Console.WriteLine("\nPromedio de sueldos: " + Math.Round(promiseSalary.Average()));
            Console.WriteLine("\nSueldo diario mas alto: " + promiseSalary.Max());
            Console.WriteLine("\nSueldo diario mas bajo: " + promiseSalary.Min());
            

            foreach (Employee personEmailandfromChile in workPerson)
            {                
                if(personEmailandfromChile.Email.IndexOf("gmail.com") >=0){cantEmail = cantEmail + 1; }
                if(personEmailandfromChile.Country.IndexOf("Chile") >= 0) { cantFromChile = cantFromChile + 1; }
            }
            Console.WriteLine("\nCantidad de trabajadores con GMAIL: " + cantEmail);
            Console.WriteLine("\nCantidad de trabajadores que resinden en Chile: " + cantFromChile);
            Console.WriteLine("\n______________________________________________________");

            foreach (Employee chargeGerent in workPerson)
            {

                if (chargeGerent.JobTitle == "Gerente")
                {
                    Console.WriteLine("\n::::::::Data charge Manager::::::::\n");
                    Console.WriteLine("Nombre trabajador : " + chargeGerent.Name);
                    Console.WriteLine("Email del trabajador : " + chargeGerent.Email);
                    Console.WriteLine("Ciudad : " + chargeGerent.City);
                    Console.WriteLine("Pais : " + chargeGerent.Country);
                    Console.WriteLine("Cargo : " + chargeGerent.JobTitle);
                    Console.WriteLine("Trabaja desde casa: " + chargeGerent.WorkHouse);
                    Console.WriteLine("Salario diario: " + chargeGerent.DailySalary);
                    Console.WriteLine("Horario de entrada: " + chargeGerent.Schedule[0] + "Hours");
                    Console.WriteLine("Horario de Salida: " + chargeGerent.Schedule[1] + "Hours");


                    Console.WriteLine("\nAsistencia Semanal - LUNES: " + chargeGerent.WeeklyAttendance[0]);
                    Console.WriteLine("\nAsistencia Semanal - MARTES: " + chargeGerent.WeeklyAttendance[1]);
                    Console.WriteLine("\nAsistencia Semanal - MIERCOLES: " + chargeGerent.WeeklyAttendance[2]);
                    Console.WriteLine("\nAsistencia Semanal - JUEVES: " + chargeGerent.WeeklyAttendance[3]);
                    Console.WriteLine("\nAsistencia Semanal - VIERNES: " + chargeGerent.WeeklyAttendance[4]);
                    Console.WriteLine("\nAsistencia Semanal - SABADO: " + chargeGerent.WeeklyAttendance[5]);
                    Console.WriteLine("\nAsistencia Semanal - DOMINGO: " + chargeGerent.WeeklyAttendance[6]);
                    Console.WriteLine("\nDias Presentes: " + chargeGerent.PresentDays);
                    Console.WriteLine("\nSueldo Semanal segun asistencia: " + chargeGerent.WeeklySalary);
                }
            }
            Console.ReadKey();

        }
    }
}
