using System;

namespace slutproject2020
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
            //skappa list med områden-
            //få klassen att fungera-
            while (round != 30)
            {
                Console.WriteLine("chose how much money you want to invest. ");
              
                biomchose = Console.ReadLine();
                bool temp = int.TryParse(biomchose, out int result);
               float valu = Skog.multi(result);
                Console.WriteLine(valu);
                Console.ReadLine();
                   
            }
        }    

    }




}
    

