using Calculadora_Teste_Automatizado.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Teste_Calculadora.Step_Definitions
{
    [Binding]
    public class CalculadoraFeatureSteps
    {
        double valor1 = 0.0;
        double valor2 = 0.0;
        Calculadora calculadora = new Calculadora();
        double resultado = 0.0;


        [Given(@"I have provided (.*) and (.*) as the inputs")]
        public void GivenIHaveProvidedAndAsTheInputs(double p0, double p1)
        {
            valor1 = p0;
            valor2 = p1;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            resultado=calculadora.Somar(valor1, valor2);
        }
        
        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            resultado = calculadora.Subtracao(valor1, valor2);
        }
        
        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            resultado = calculadora.Multiplicar(valor1, valor2);
        }
        
        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            resultado = calculadora.Dividir(valor1, valor2);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.AreEqual(p0, resultado);
        }
        
     
    }
}
