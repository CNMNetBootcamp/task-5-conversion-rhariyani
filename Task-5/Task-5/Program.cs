using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {


            
            double cups = 0.0;
            double quarts = 0.0;

            int choice;
            int option= 0 ;
            string Question = "Y";

            do
            {

                Console.WriteLine("What do you want to do? 1.cups to quarts , 2.quarts to cups :");
            choice = int.Parse(Console.ReadLine());


            }
            while(option >=2);

            {
                Console.ReadLine();
            }

            ////process
            do
            {
                if (choice == 1)

                {
                    Console.WriteLine("Enter number of cups :");
                    cups = int.Parse(Console.ReadLine());

                    quarts = cups * 4;
                    Console.WriteLine("The conversion of cups to quarts is:" + quarts);
                }

                else
                {
                    Console.WriteLine("Enter number of quarts :");
                    quarts = int.Parse(Console.ReadLine());
                    cups = quarts * 4;
                    Console.WriteLine("The coversion of quarts to cup is:" + cups);
                }

                Console.WriteLine("Do you want to Continue? Y or N");
                Question = Console.ReadLine();

            } while (Question != "N");
            Console.ReadLine();
        }
    }

}


            


        
   
