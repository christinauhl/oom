using System;

namespace Task2
{

    public class Lens
    {

        //fields
        private double focalmax, focalmin;

        public Lens(string brand, double focallengthmax, double focallengthmin, double price)
        {
            if (string.IsNullOrWhiteSpace(brand)) throw new ArgumentException("Brand must not be empty.", nameof(brand));

            Brand = brand;
            Price = price;
            focalmax = focallengthmax;
            focalmin = focallengthmin;
        }

        //public field to get the lens brand
        public string Brand
        {
            get;
        }

        //public field to get/set the price
		public double Price
        {
            get;
            set;
		}

		//method (= function) to calculate the focal lenght 
		public double Focallength()
		{
			return focalmax - focalmin;
		}

		//method to describe the lens 
		public string Describe() {
            return "The name of the camera is " + Brand + ", the focallength = " + Focallength();
        }

		//method to update the price 
		public void ChangePrice(double newPrice) {

            Price = newPrice;
        }
	}



	class Program
	{
		static void Main(string[] args)
		{

			Lens Lens1 = new Lens("Sony", 300, 75, 89.99);   // Declares Lens1 of type Lens

			Console.WriteLine(Lens1.Brand);
            Console.WriteLine(Lens1.Price);
			Console.WriteLine(Lens1.Focallength());
			Console.WriteLine(Lens1.Describe());
            Lens1.Price = 300;

            Console.WriteLine("The Price from " + Lens1.Brand + " has changed to: " + Lens1.Price);

            Lens1.ChangePrice(500);
            Console.WriteLine("The Price from " + Lens1.Brand + " has changed again to: " + Lens1.Price);
		}
	}
}

