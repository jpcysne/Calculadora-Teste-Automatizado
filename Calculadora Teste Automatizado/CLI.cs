using Calculadora_Teste_Automatizado.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Teste_Automatizado
{
    public class CLI
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculadora!");

            Console.WriteLine("Escolha o primeiro valor!");
            double valor1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o tipo de operação!");
            string operador = Console.ReadLine();
            Console.WriteLine("Escolha o segundo valor!");
            double valor2 = Double.Parse(Console.ReadLine()); 

            Calculadora cal = new Calculadora();
            double resultado = 0.0;

            switch (operador)
            {
                case "+":
                    Console.WriteLine("Somar!");
                    resultado = cal.Somar(valor1, valor2);
                    
                    break;

                case "-":
                    Console.WriteLine("Subtracao!");
                    resultado = cal.Subtracao(valor1, valor2);

                    break;

                case "*":
                    Console.WriteLine("Multiplicar!");
                    resultado = cal.Multiplicar(valor1, valor2);

                    break;

                case "/":
                    Console.WriteLine("Dividir!");
                    resultado = cal.Dividir(valor1, valor2);

                    break;
            }

            Console.WriteLine("Resultado = " + resultado);

        }
    }
}
