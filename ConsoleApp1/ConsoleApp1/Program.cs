using System;
using System.Collections.Generic;

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
            Console.WriteLine("your jobb is to rule the kindgodom and to survive for 30 days with the founds you have");
            Console.WriteLine("Starting founds are 30 000");

            Console.ReadKey();
            //skappa list med områden-
            //få klassen att fungera-
            List<Områden> lista = new List<Områden>();
            Random generator = new Random();
            for (int i = 0; i < 30; i++)
            {
                Områden område = new Områden();
                int x = generator.Next(1,4);
                if (x == 1)
                {
                 område = new Skog();
                }
                if (x == 2)
                {
                    område = new Sand();
                }
                if (x == 3)
                {
                     område = new Träsk();
                }
              
             

               lista.Add(område);
              
                
            }

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("How much money do you want to invest in the area");
                Console.WriteLine(lista[i].Area);
               
                biomchose = Console.ReadLine();
            bool temp = int.TryParse(biomchose, out int result);
                float value = lista[i].multi(result);
                Console.WriteLine(value); 
               Console.ReadLine();
                
               
            }
                     
        }    

    }




}
    

