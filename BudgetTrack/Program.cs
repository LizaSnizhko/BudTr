﻿namespace Program
{
    public class BudgetTracking
    {
        public static void Main(string[] args)
        {
            Tracking();
        }
        public static void Tracking()
        {
            int sum = 0;
            bool if_exit = true;

            while (if_exit)
            {
                Console.WriteLine("\nChoose the option:\n\n1 Add \n2 Subtract \n3 Show current balance\n4 Exit\n");
                int option = CheckInt(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the income sum:");
                        int income = -1;
                        while (income == -1) income = CheckInt(Console.ReadLine());
                        sum += income;
                        break;
                    case 2:
                        Console.WriteLine("Enter the expence sum:");
                        int expence = -1;
                        while (expence == -1) expence = CheckInt(Console.ReadLine());
                        sum -= expence;
                        break;
                    case 3:
                        Console.WriteLine("Current balance: " + sum);
                        break;
                    case 4:
                        if_exit = false;
                        break;
                    case -1:
                        break;
                    default:
                        Console.WriteLine("enter nuber from 1 to 4 only");
                        break;
                }
            }
        }
        public static int CheckInt(string? input)
        {
            if (Int32.TryParse(input, out int m)) return m;
            Console.WriteLine("Enter valid integer");
            return -1;
        }
    }
}