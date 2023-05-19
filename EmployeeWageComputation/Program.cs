using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagePerHour = 20;
            int fullDayHours = 8;
            int partTimeHours = 4;
            int workingDaysPerMonth = 20;
            int maxWorkingHours = 100;
            int totalWorkingDays = 0;
            int totalWorkingHours = 0;
            int dailyWage = 0;
            int monthlyWage = 0;

            Random random = new Random();
            int attendance = random.Next(0, 2); // 0 for absent, 1 for present

            if (attendance == 1)
            {
                Console.WriteLine("Employee is Present");

                // UC 1: Calculate Daily Employee Wage
                dailyWage = wagePerHour * fullDayHours;
                Console.WriteLine("Daily Employee Wage: " + dailyWage);

                // UC 2: Add Part Time Employee & Wage
                dailyWage = wagePerHour * partTimeHours;
                Console.WriteLine("Part Time Employee Wage: " + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

            // UC 3: Solving using Switch Case Statement
            int empType = random.Next(0, 2); // 0 for full-time, 1 for part-time
            switch (empType)
            {
                case 0:
                    Console.WriteLine("Employee Type: Full Time");
                    dailyWage = wagePerHour * fullDayHours;
                    Console.WriteLine("Employee Wage: " + dailyWage);
                    break;
                case 1:
                    Console.WriteLine("Employee Type: Part Time");
                    dailyWage = wagePerHour * partTimeHours;
                    Console.WriteLine("Employee Wage: " + dailyWage);
                    break;
                default:
                    Console.WriteLine("Invalid Employee Type");
                    break;
            }

            // UC 4: Calculating Wages for a Month
            monthlyWage = dailyWage * workingDaysPerMonth;
            Console.WriteLine("Monthly Employee Wage: " + monthlyWage);

            // UC 5: Calculate Wages till a condition of total working hours or days is reached for a month
            while (totalWorkingDays < workingDaysPerMonth && totalWorkingHours < maxWorkingHours)
            {
                totalWorkingDays++;
                totalWorkingHours += fullDayHours;
                dailyWage = wagePerHour * fullDayHours;
                monthlyWage += dailyWage;
            }
            Console.WriteLine("Total Working Days: " + totalWorkingDays);
            Console.WriteLine("Total Working Hours: " + totalWorkingHours);
            Console.WriteLine("Monthly Employee Wage (with condition): " + monthlyWage);
        }
    }
}

