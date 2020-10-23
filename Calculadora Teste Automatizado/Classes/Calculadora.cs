using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Teste_Automatizado.Classes
{
    public class Calculadora
    {
        double resultado;
        public double Somar(double valor1, double valor2)
        {
            resultado = 0.0;
            resultado = valor1 + valor2;
            return resultado;
        }
        public double Subtracao(double valor1, double valor2)
        {
            resultado = 0.0;
            resultado = valor1 - valor2;
            return resultado;
        }
        public double Multiplicar(double valor1, double valor2)
        {
            resultado = 0.0;
            resultado = valor1 * valor2;
            return valor1 * valor2;
        }
        public double Dividir(double valor1, double valor2)
        {
            resultado = 0.0;
            resultado = valor1 / valor2;
            return resultado;
        }
    }
}
