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
            
            List<Områden> lista = new List<Områden>();// här är listan "lista"
            Random generator = new Random();//generator som randomar ett nummer
            for (int i = 0; i < 30; i++)
            {// Den beronde vad för nummer som random gene ger skappar den en instans av Den klassen
                Områden område = new Områden();
                int x = generator.Next(1,4);// tar ett nummer mellan 1.4
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
               //den lägger in värdet i en lista och sedan läser den up listan och då berättar vad värdet blev
                biomchose = Console.ReadLine();//samlar in användarens svar
            bool temp = int.TryParse(biomchose, out int result);// deb här gör en String till en int och lägger in den i result.
                float value = lista[i].multi(result);




                Console.WriteLine(value); 
               Console.ReadLine();
                
               
            }
                     
        }    

    }




}
    

