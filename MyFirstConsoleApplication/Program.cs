using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args) {
            string myName = "Darien Weller", myLocation = "Utah";
            DateTime currentDate = DateTime.Now;
            DateTime christmasDate = new DateTime(currentDate.Year, 12, 25);
            string formattedDate = currentDate.ToString("MM/dd/yyyy");
            TimeSpan timeUntilChristmas = christmasDate - currentDate;
            int daysUntilChristmas = (int)(timeUntilChristmas.TotalDays);


            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"My location is {myLocation}");
            Console.WriteLine($"Today's date is {formattedDate}");
            Console.WriteLine($"There are {daysUntilChristmas} days until christmas");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Please enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
