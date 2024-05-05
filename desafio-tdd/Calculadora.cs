using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_tdd
{
    

    public class Calculadora
    {
        private List<string> historico;
        private DateTime data;

        public Calculadora(DateTime data)
        {
            historico = new List<string>();
            this.data = data;
        }
        public int Somar(int num1, int num2) 
        {
            int res = num1 + num2;
            historico.Insert(0, $"Resultado: {res}\nData: {data}");
            return res;
        }

        public int Subtrair(int num1, int num2) 
        { 
            int res = num1 - num2;
            //historico.Insert(0, "Resultado: " + res);
            historico.Insert(0, $"Resultado: {res}\nData: {data}");
            return res;
        }
        public int Multiplicar(int num1, int num2) 
        {
            int res = num1 * num2;
            //historico.Insert(0, "Resultado: " + res);
            historico.Insert(0, $"Resultado: {res}\nData: {data}");
            return res;
        }
        public int Dividir(int num1, int num2) 
        {
            int res = num1 / num2;
            //historico.Insert(0, "Resultado: " + res);
            historico.Insert(0, $"Resultado: {res}\nData: {data}");
            return res;
        }

        public List<string> Historico() 
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }

    }
}
