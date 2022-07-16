public class Program

{

    public static void Main()

    {

        while (true)

        {

            Console.WriteLine("Hello!\nDo you want to know the schedule for the week?\nPress 'y', else press another symbol.");

            if (Console.ReadLine() == "y")

                ToDoList();

            else

            {

                Console.WriteLine("Good buy! See you later!");

                break;

            }

        }

    }

    public static void ToDoList()

    {

        string[] daysOfWeek = { "1 Monday", "2 Tuersday", "3 Wednesday", "4 Thirsday", "5 Friday", "6 Saturday", "7 Sunday" };

        //need to know Length of string array

        //Console.WriteLine($"Length of string array daysOfWeek is = {daysOfWeek.Length}");

        //Console.ReadLine();

        int Nday;

        Console.WriteLine("Please input number days of week (from 1 to 7):");

        var InputNday = Console.ReadLine();

        Nday = int.Parse(InputNday);

        Nday = Nday - 1; //I think need to decrement Nday because string array daysOfWeek start from [0] to [6]

        for (int i = 0; i < daysOfWeek.Length; i++)

        {

            if (Nday == i & Nday >= 5)

            {

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("NumberInArray[{0}] = {1} ", i, daysOfWeek[i]);

                Console.ResetColor();

                Console.WriteLine("To continue press Enter...");

            }

            if (Nday == i & Nday < 5)

            {

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("NumberInArray[{0}] = {1}", i, daysOfWeek[i]);

                Console.ResetColor();

                Console.WriteLine("To continue press Enter...");

            }

        }


        // check out of range

        if (Nday < 0 | Nday >= 7)

            Console.WriteLine("Out of range from 1 to 7, try again!\nPress Enter to continue...");

        Console.ReadKey();

    }

}