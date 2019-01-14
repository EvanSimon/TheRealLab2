using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                double Room1length, Room1width, Room1height, Room2width, Room2length, Room2height, Room1area, Room1perimeter, Room2area, Room2perimeter, Room1Volume, Room2Volume;
                string UserAnswer;

                Console.WriteLine("Enter length of the first room ");
                Room1length = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter width of the first room ");
                Room1width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height of the first room");
                Room1height = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter length of the secound room ");
                Room2length = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter width of the secound room ");
                Room2width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height of the secound room");
                Room2height = Convert.ToDouble(Console.ReadLine());

                Room1perimeter = 2 * Room1length + 2 * Room1width;

                Console.WriteLine("The perimeter of the first room is {0}\"", Room1perimeter);

                Room1area = Room1length * Room1width;

                Console.WriteLine("The area of the first room is {0}\"", Room1area);

                Room2perimeter = 2 * Room2length + 2 * Room2width;

                Console.WriteLine("The perimeter of the secound room is {0}\"", Room2perimeter);

                Room1Volume = Room1area * Room1height;

                Console.WriteLine("The volume of the first room is {0}\"", Room1Volume);

                Room2area = Room2length * Room2width;

                Console.WriteLine("The area of the secound room is {0}\"", Room2area);

                Room2Volume = Room2area * Room2height;

                Console.WriteLine("The volume of the secound room is {0}\"", Room2Volume);

                Console.WriteLine("Would you like to continue (y/n)");
                UserAnswer = Console.ReadLine().ToLower();

                if (UserAnswer == "y")
                {
                    continue;
                }

                else
                {
                    break;
                }
            }
            
        }
    }
}
