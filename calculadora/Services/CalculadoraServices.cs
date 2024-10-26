using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculadora.Interfaces;

namespace calculadora.Services
{
    public class CalculadoraServices : ICalculadoraServices
    {
        public int Dividir(int a, int b) => a / b;

        public int Multiplicar(int a, int b) => a * b;

        public int Somar(int a, int b) => a + b;

        public int Subtrair(int a, int b) => a - b;

        public List<string> ListOperacoes()
        {
            throw new NotImplementedException();
        }
    }
}