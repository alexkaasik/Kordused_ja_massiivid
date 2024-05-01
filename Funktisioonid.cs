using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kordused_ja_massiivid
{
    public class Funktisioonid
    {

        public static void help(){
            Console.WriteLine("h - abi");
            Console.WriteLine("r - RuududEkraanile");
            Console.WriteLine("k - Keskmine_summa");
            Console.WriteLine("e - Elevant");
            Console.WriteLine("g - GuessRandomNumber");
            Console.WriteLine("n - neliarvuline");
            Console.WriteLine("m - Korrutustabel");
        }
        
        public static void andmeid() {
            List<Tuple<int, string>> user = new List<Tuple<int, string>>();
            user.Add(Tuple.Create(4, "test0"));
            user.Add(Tuple.Create(4, "test1"));
            user.Add(Tuple.Create(4, "test2"));

            Console.WriteLine(user);
        }
        

        public static void RuududEkraanile() {
            Random N = new Random();
            Random M = new Random();

            int n = (int)N.Next(100);
            int m = (int)N.Next(100);

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < m; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        public static void Keskmine_summa() {
            int MaxEnd = 5;
            int testinput = 0;
            for (int y = 0; y < MaxEnd; y++)
            {   
                bool co = true;
                Console.Write("lisage arv: ");
                string test = Console.ReadLine();
                
                if (test == ""){ test = " "; }

                foreach (char value in test)
                {
                    if ( !"0123456789".Contains(value.ToString())) {
                        y = y-1;
                        co = false;
                        break;
                    }
                }

                if (co == true){testinput += int.Parse(test);}               
            }
            Console.WriteLine("\nKeskmine: " + testinput / MaxEnd);
        }

        public static void Elevant()
        {
            string guess = "";
            do
            {
                guess = Console.ReadLine();
            }
            while (guess.ToLower() != "elevant");
           
        }  

        public static void GuessRandomNumber()
        {
            int wins = 0;
            for (int y = 0; y < 5; y++)
            {
                Random rnd = new Random();
                int answer = rnd.Next(10);

                Console.Write(y+1+"/5\nMis arv:");
                string guess = Console.ReadLine();
                
                if (guess == ""){ guess = " "; }

                foreach (char value in guess)
                {
                    if ( !"0123456789".Contains(value.ToString())) {
                        y = y-1;
                        break;
                    }
                }

                if (answer.ToString() == guess) { wins++; }
                
            }
            Console.WriteLine((wins / 5) * 100 + "% win" );
        } 

        public static void Neliarvu() 
        {
            int MaxEnd = 4;
            int[] testinput = new int[4];

            for (int y = 0; y < MaxEnd; y++)
            {
                bool co = true;
                Console.Write(y+1+"/"+MaxEnd+": ");
                string test = Console.ReadLine();
                
                if (test == ""){ test = " "; }

                foreach (char value in test)
                {
                    if ( !"0123456789".Contains(value.ToString())) {
                        y = y-1;
                        co = false;
                        break;
                    }
                }
                if (co == true) {testinput[y] = int.Parse(test);}
                
            }
            Console.WriteLine();
            Array.Sort(testinput);
            Console.WriteLine("suurim neliarvuline arv: " + testinput[MaxEnd-1]);
        }

        public static void Multiply() {
            // Korrutustabel väljata ekraanile sellisel kujul:
            for (int y = 1; y <= 10; y++) {
                for (int x = 1; x <= 10; x++)
                {
                    Console.Write(x*y);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
