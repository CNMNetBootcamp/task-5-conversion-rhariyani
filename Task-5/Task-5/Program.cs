using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {

            double cups = 0.0;
            double quarts = 0.0;
            bool? status = null;
            int choice = 0;
            //int option= 0 ;
            string question =  String.Empty;

            string tempnum = string.Empty;
            bool isNumeric = true;

            do
            {


                
                        do
                        {


                            Console.WriteLine("What do you want to do? 1.cups to quarts , 2.quarts to cups :");


                            tempnum = Console.ReadLine();
                            isNumeric = double.TryParse(tempnum, out double n);
                            if (isNumeric == false || double.Parse(tempnum) <= 0 || double.Parse(tempnum) > 2)
                            {
                                Console.WriteLine("Please enter a number between 1 and 2");
                                isNumeric = false;
                            }

                        } while (isNumeric == false || double.Parse(tempnum) <= 0 || double.Parse(tempnum) > 2);
                        choice = int.Parse(tempnum);

                do
                    {

                    do
                    {
                        if (status == false)

                        {
                            Console.Clear();
                            Console.WriteLine("Please enter numeric value");
                            Console.ReadLine();
                        }
                        if (choice == 1)
                        {
                            Console.WriteLine("Enter number of cups :");
                            status = double.TryParse(Console.ReadLine(), out cups);

                            quarts = cups * 4;
                            Console.WriteLine("The conversion of cups to quarts is:" + quarts);


                        } 
                        else
                        {
                            Console.WriteLine("Enter number of quarts :");
                            status = double.TryParse(Console.ReadLine(), out quarts);
                            cups = quarts * 4;
                            Console.WriteLine("The coversion of quarts to cup is:" + cups);
                        }

                    } while (status == false);
                    Console.ReadLine();
                    //Press enter once equation is over
                } while (choice > 2);
                    Console.WriteLine("Do you want to Continue? Y or N");
                question = Console.ReadLine();
            } while (question != "N");
                
      

                    
               
            

           












        }

    }
}























