using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string biomchose;
            int round = 0;
            int Money = 30000;
            Console.WriteLine("Welcome to kingdome game!");
            Console.ReadLine();
            Console.WriteLine("your jobb is to rule the kindgodom and to survive for 10 days with the founds you have");
            Console.WriteLine("Starting founds are 30 000");

            Console.ReadKey();

            while( round != 30 )
            {
                Console.WriteLine("chose on of the following bioms to invest in ");
                Console.WriteLine("Träsk");
                Console.WriteLine("Skog");
                Console.WriteLine("sand");
               biomchose =  Console.ReadLine();
                if (biomchose == "träsk")
                {

                }
                if (biomchose == "skog")
                {


                }
                if (biomchose == "sand")
                round++;
                
            }
           
        }
    }
}
