using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora_Teste_Automatizado.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora_Teste_Automatizado.Classes.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        double resultadoTest=0.0;
        double valorDesejado = 0.0;
        [TestMethod()]
        public void somarTest()
        {
            Calculadora calculadora = new Calculadora();

            double valorTest1 = 0.3;
            double valorTest2 = 0.4;
            valorDesejado=0.7;

            resultadoTest =calculadora.Somar(valorTest1, valorTest2);

            Assert.AreEqual(resultadoTest,valorDesejado,"Somar test não deu certo");
        }
        [TestMethod()]
        public void subtracaoTest()
        {
            Calculadora calculadora = new Calculadora();

            double valorTest1 = 3.5;
            double valorTest2 = 2.5;
            valorDesejado = 1.0;

            resultadoTest = calculadora.Subtracao(valorTest1, valorTest2);

            Assert.AreEqual(resultadoTest, valorDesejado, "Subtracao test não deu certo");
        }
        [TestMethod()]
        public void multiplicacaoTest()
        {
            Calculadora calculadora = new Calculadora();

            double valorTest1 = 0.5;
            double valorTest2 = 0.5;
            valorDesejado = 0.25;

            resultadoTest = calculadora.Multiplicar(valorTest1, valorTest2);

            Assert.AreEqual(resultadoTest, valorDesejado, "Multiplicar test não deu certo");
        }
        [TestMethod()]
        public void dividirTest()
        {
            Calculadora calculadora = new Calculadora();

            double valorTest1 = 6.2;
            double valorTest2 = 0.2;
            valorDesejado = 31.0;

            resultadoTest = calculadora.Dividir(valorTest1, valorTest2);

            Assert.AreEqual(resultadoTest, valorDesejado, "Dividir test não deu certo");
        }
    }
}