using System;

namespace Pa2
{
    class Program
    {
        static void Main()
        {
            displayMenu();

        }
        static void displayMenu()
        {
            int selection = 0;
            do
            {
                Console.WriteLine("1__Add a list car." +
                                "\n2__Show list car." +
                                "\n3__Add a list bike." +
                                "\n4__Show list bike." +
                                "\n5__Exit.");
                int.TryParse(Console.ReadLine(), out selection);
                Console.WriteLine("**********************************");
                if (selection == 0)
                    Console.WriteLine("<!> Error input, please input number 1, 2, 3, 4 or 5." +
                                    "\n**********************************");
            } while (selection < 1 || selection > 5);
            process(selection);
        }
        static void process(int a)
        {
            switch (a)
            {
                case 1:
                    addCar();
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:
                    break;
            }
        }
        static void addCar()
        {
            Console.Write("Input the length of list car:");

        }
    }
}
