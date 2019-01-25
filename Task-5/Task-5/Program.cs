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
            //TODO: Local variables need to be lowercase.
            string Question = "Y";

            do
            {

                Console.WriteLine("What do you want to do? 1.cups to quarts , 2.quarts to cups :");
            choice = int.Parse(Console.ReadLine());


            }
            while(option >=2);

            {
                //TODO: Why are you halting the program? This needs to execute some type of logic. 
                // Example store it to a variable and display it. 
                Console.ReadLine();
            }

            

            ////process
            do
            {
                if (choice == 1)

                {
                    Console.WriteLine("Enter number of cups :");
                    //TODO: Cups is a double not an int
                    cups = int.Parse(Console.ReadLine());

                    quarts = cups * 4;
                    Console.WriteLine("The conversion of cups to quarts is:" + quarts);
                }
                //TODO: This is incorrect. The user only has 2 options not three. 
                else
                {
                    Console.WriteLine("Enter number of quarts :");
                    //TODO: YOu still need to handle if a user enters a String
                    //TODO: You need to handle if the user passes in a String. When I enter J it breaks the program
                    quarts = int.Parse(Console.ReadLine());
                    cups = quarts * 4;
                    Console.WriteLine("The coversion of quarts to cup is:" + cups);
                }

                Console.WriteLine("Do you want to Continue? Y or N");
                Question = Console.ReadLine();
                //TODO: Loops when I press N it doesnt exit the program. 
            } while (Question != "N");
            Console.ReadLine();
        }
    }

}


            


        
   
