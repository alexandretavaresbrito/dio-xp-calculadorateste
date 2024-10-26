using calculadora.Interfaces;

namespace calculadora.Services
{
    public class CalculadoraServices : ICalculadoraServices
    {
        private List<string> historico = new List<string>();
        private DateTime pegaData = new DateTime();

        public int Dividir(int a, int b)
        {
            int resultado = a / b;
            historico.Insert(0, $"Divisão = {resultado} em {pegaData.ToString()}");
            return resultado;
        }

        public int Multiplicar(int a, int b)
        {
            int resultado = a * b;
            historico.Insert(0, $"Multiplicação = {resultado} em {pegaData.ToString()}");
            return resultado;
        }

        public int Somar(int a, int b)
        {
            int resultado = a + b;
            historico.Insert(0, $"Soma = {resultado} em {pegaData.ToString()}");
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            historico.Insert(0, $"Subtração = {resultado} em {pegaData.ToString()}");
            return resultado;
        }

        public List<string> HistoricoOperacoes()
        {
            historico.RemoveRange(3, historico.Count() - 3);
            return historico;
        }
    }
}