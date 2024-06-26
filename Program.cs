﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu ();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione a função desejada: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------------");

            int res = int.Parse(Console.ReadLine());

            switch(res) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
                
            }

        }
        static void Soma() 
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 + v2;
            
            // Console.WriteLine(v1);
            // Console.WriteLine(v2);

            // Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine($"O resultado da soma é: {resultado}");
            // Console.WriteLine($"O resultado da soma é: {v1 + v2}");
            // Console.WriteLine("O resultado da soma é: " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }
    
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Sergundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1/v2;
            Console.WriteLine($"O Resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            float resultado = v1*v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}