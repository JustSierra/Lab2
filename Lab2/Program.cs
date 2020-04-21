using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            double length, width, volume, area, perimeter, height;

            Console.WriteLine("What is the length of your room?");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of your room?");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the volume of your room?");
            volume = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the height of your room?");
            height = double.Parse(Console.ReadLine());
            perimeter = length + width * 2;

            area = length * width;

            volume = length * width * height;

            Console.WriteLine("The perimeter of the room is" + perimeter);

            Console.WriteLine("The area of th room is" + area);

            Console.WriteLine("the volume of the room is" + volume);


            bool condition = true;

            Console.WriteLine("Would you like to continue?");

            if (condition)
            {
                Console.WriteLine("Enter the length of room");
            }
            else
            {
                Console.WriteLine(" Have a good day");
            }


            Console.ReadLine();

        }
    }
}
