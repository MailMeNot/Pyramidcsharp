using System;
namespace Pyramid{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Pyramid Height?");
            int Height = Int32.Parse(Console.ReadLine());
            int Spaces = Height-1;
            int Stars = 1;
            for (int i = 0; i < Height; i++){
                for (int loop = 0; i < Spaces; loop++){
                    Console.Write(" ");}  
                Spaces = Spaces - 1;
                for (int loop = 0; loop < Stars; loop++){
                    Console.Write("*");}
                Stars = Stars + 2; 
                Console.WriteLine();}}}}
