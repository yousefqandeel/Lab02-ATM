using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{

        public class ATM
        {
            public static decimal BALANCE = 0;

            public static decimal ViewBalance()
            {
                return BALANCE;
            }

            public static decimal Withdraw(decimal amount)
            {
                if (amount > BALANCE)
                {
                    Console.WriteLine("You can not withdraw " + amount + "! Your balance is: " + BALANCE);
                    return BALANCE;
                }

                if (amount < 1)
                {
                    Console.WriteLine("You can not withdraw less than ONE!");
                    return BALANCE;
                }

                BALANCE -= amount;

                return BALANCE;
            }
            public static decimal Deposit(decimal amount)
            {
                if (amount < 1)
                {
                    Console.WriteLine("You can not deposit less than ONE!");
                    return BALANCE;
                }

                BALANCE += amount;

                return BALANCE;
            }

            public static void Start()
            {
                Console.WriteLine("Welcome to ATM!");

                decimal run = 0;
                while (run != -1)
                {
                    Console.WriteLine("Enter the NUMBER of the operation you want to do.");
                    Console.WriteLine("1. Check Balance.");
                    Console.WriteLine("2. Withdraw.");
                    Console.WriteLine("3. Deposit.");
                    Console.WriteLine("-1. Exit.");

                    string input = Console.ReadLine();
                    try
                    {
                        run = Convert.ToDecimal(input);

                        switch (run)
                        {
                            case 1:
                                Console.WriteLine("Your balance is: " + BALANCE);
                                break;
                            case 2:
                                Console.WriteLine("Enter the amount:");
                                string withdrawInput = Console.ReadLine();
                                decimal withdrawAmount = Convert.ToDecimal(withdrawInput);
                                Withdraw(withdrawAmount);
                                Console.WriteLine("Your balance is: " + BALANCE);
                                break;
                            case 3:
                                Console.WriteLine("Enter the amount:");
                                string depositInput = Console.ReadLine();
                                decimal depositAmount = Convert.ToDecimal(depositInput);
                                Deposit(depositAmount);
                                Console.WriteLine("Your balance is: " + BALANCE);
                                break;
                            case -1:
                                run = -1;
                                break;
                        }
                        Console.WriteLine("----------------------------");

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Somthing went wrong! " + e);
                    }

                }

                Console.WriteLine("GoodBye!");

            }
        }
   
}
