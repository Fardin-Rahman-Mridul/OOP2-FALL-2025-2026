using System;

namespace HouseExercise
{
    class House
    {
        private int _yearBuilt;
        private double _size;

        public House(int yearBuilt, double size)
        {
            _yearBuilt = yearBuilt;
            _size = size;
        }

        public int YearBuilt
        {
            get { return _yearBuilt; }
            private set { _yearBuilt = value; }
        }

        public double Size
        {
            get { return _size; }
            private set { _size = value; }
        }

        private int HowOld()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear;
        }
        public bool CanBeSold()
        {
            return HowOld() > 15;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\n----House Information----");
            Console.WriteLine("Year Built: " + YearBuilt);
            Console.WriteLine("Size: " + Size + " sq. units");
            Console.WriteLine("Can be sold: " + CanBeSold());
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("House Details Input ===>");

            Console.Write("Enter the year the house was built: ");
            string? yearBuiltInput = Console.ReadLine();
            if (!int.TryParse(yearBuiltInput, out int yearBuilt))
            {
                Console.WriteLine("Invalid input for year built. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the size of the house: ");
            string? sizeInput = Console.ReadLine();
            if (!double.TryParse(sizeInput, out double size))
            {
                Console.WriteLine("Invalid input for size. Please enter a valid number.");
                return;
            }

            House house = new House(yearBuilt, size);

            house.DisplayInfo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}