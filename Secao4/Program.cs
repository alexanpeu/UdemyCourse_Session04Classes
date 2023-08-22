using System;
using System.Globalization;

namespace Secao4
{
    class Program
    {
        //lesson about static classes
        static double PiMode1 = 3.14;


        static void Main(string[] args)
        {
            //Program 01
            /*
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Enter with triangle X measure:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter with triangle Y measure:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if(areaX > areaY)
                Console.WriteLine("The biggest triangle is X");
            else
                Console.WriteLine("The biggest triangle is Y");
            */

            //program exercise 01
            /*
            Pessoas person1, person2;
            person1 = new Pessoas();
            person2 = new Pessoas();

            Console.WriteLine("Date from person 1:");
            Console.Write("Name: ");
            person1.Name = Console.ReadLine();
            Console.Write("Age: ");
            person1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Date from person 2:");
            Console.Write("Name: ");
            person2.Name = Console.ReadLine();
            Console.Write("Age: ");
            person2.Age = int.Parse(Console.ReadLine());

            if(person1.Age > person2.Age)
                Console.WriteLine("Old person : {0}", person1.Name);
            else if(person1.Age == person2.Age)
                Console.WriteLine("Same ages!");
            else
                Console.WriteLine("Old person : {0}", person2.Name);
            */

            //program exercise 02
            /*
            Employee employee1, employee2;
            employee1 = new Employee();
            employee2 = new Employee();

            Console.WriteLine("Date from employee 1:");
            Console.Write("Name: ");
            employee1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            employee1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Date from employee 2:");
            Console.Write("Name: ");
            employee2.Name = Console.ReadLine();
            Console.Write("Age: ");
            employee2.Salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double averageSalary = (employee1.Salary + employee2.Salary)/2;
            Console.WriteLine("Average Salary: " + averageSalary.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //program 02 
            Product p = new Product();

            Console.WriteLine("Enter with product date:");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Stock Quantity: ");
            p.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Products date: " + p);

            Console.WriteLine();
            Console.Write("Add quantity:");
            int quant = int.Parse(Console.ReadLine());
            p.AddQuantity(quant);
            Console.WriteLine("Products date: " + p);

            Console.WriteLine();
            Console.Write("Subctract quantity:");
            quant = int.Parse(Console.ReadLine());
            p.SubtractQuantity(quant);
            Console.WriteLine("Products date: " + p);

            */

            /*
            //proposed exercises 01
            Exercise1Rectangle rec = new Exercise1Rectangle();

            Console.WriteLine("Enter the width and height of the retangle");
            rec.Width  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rec.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area = " + rec.CalcArea().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter = " + rec.CalcPerimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + rec.CalDiagonal().ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //proposed exercise 02
            Exercise2Salary exc02 = new Exercise2Salary();
            
            Console.Write("Name: ");
            exc02.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            exc02.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            exc02.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double netSalary = exc02.NetSalary();
            Console.WriteLine();

            Console.WriteLine("Employee: " + exc02 + netSalary.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Enter the percentage to increase the salary: ");
            exc02.RaiseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            netSalary = exc02.NetSalary();

            Console.WriteLine();
            Console.WriteLine("Update data: " + exc02 + netSalary.ToString("F2", CultureInfo.InvariantCulture));
        
            */

            /*
            //lesson about static classes Mode 1
            Console.WriteLine("Enter the value of the radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = CircunferenceMode1(radius);
            Console.WriteLine("Circunference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + VolumeMode1(radius).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI value: " + PiMode1.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //lesson about static classes Mode 2
            StaticCalculator calcMode2 = new StaticCalculator();

            Console.WriteLine("Enter the value of the radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calcMode2.CircunferenceMode2(radius);
            Console.WriteLine("Circunference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + calcMode2.VolumeMode2(radius).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI value: " + calcMode2.PiMode2.ToString("F2", CultureInfo.InvariantCulture));
            */

            /*
            //lesson about static classes Mode 3 
            Console.WriteLine("Enter the value of the radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = StaticCalculator.CircunferenceMode3(radius);
            Console.WriteLine("Circunference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + StaticCalculator.VolumeMode3(radius).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI value: " + StaticCalculator.PiMode3.ToString("F2", CultureInfo.InvariantCulture));
            */

            //Exercise 01 about static class
            Console.Write("What the dollar price? ");
            double priceD = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many dollars do you will buy? ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Value will to pay in Real: " + ExerciseStaticCurrencyConverter.ConverterCurrency(priceD, amount).ToString("F2", CultureInfo.InvariantCulture));


        }


        //lesson about static classes Mode 1
        static double CircunferenceMode1(double r)
        {
            return 2.0 * PiMode1 * r;
        }
        
        static double VolumeMode1(double r)
        {
            return 4.0 / 3.0 * PiMode1 * Math.Pow(r, 3.0);
        }

    }
}
