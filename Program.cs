using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kordused_ja_massiivid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funktisioonid.help();
            string mode = "a";
            Console.Write("Mode: ");
            mode = Console.ReadLine();

            switch (mode){
                case "h":
                    Funktisioonid.help();
                    break;
                case "r":
                    Funktisioonid.RuududEkraanile();
                    break;
                case "k": 
                    Funktisioonid.Keskmine_summa();
                    break;
                    
                case "a": 
                    Funktisioonid.andmeid();
                    break;
                    
                case "e": 
                    Funktisioonid.Elevant();
                    break;
                case "g":
                    Funktisioonid.GuessRandomNumber();
                    break;
                case "n":
                    Funktisioonid.Neliarvu();
                    break;
                case "m": 
                    Funktisioonid.Multiply();
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
