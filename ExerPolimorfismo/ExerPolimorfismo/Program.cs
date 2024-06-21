using System.Globalization;

using ExerPolimorfismo.Entites;


namespace ExerPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employe> list = new List<Employe>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee number #" + i +" data");
                Console.Write("Outsourced (y/n?) : ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                if(ch == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employe(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employe emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }

        }
    }
}
