using System;

namespace Properties_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigns the make and model for car
            Car car = new Car();
            car.Make = "Chevrolet";
            car.Model = "Corvette";

            //Prints to console
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            //Assigns the make and model for car2
            Car car2 = new Car();
            car2.Make = "Ford";
            car2.Model = "Mustang";

            //Prints to console
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            //Assigns the make and model for car3
            Car car3 = new Car();
            car3.Make = "Nissan";
            car3.Model = "Altima";

            //Prints to console
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");

        }
    }
}
