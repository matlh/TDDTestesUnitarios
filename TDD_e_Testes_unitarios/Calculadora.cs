using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_e_Testes_unitarios
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public decimal somar (decimal num1, decimal num2)
        {
            decimal resultado = num1 + num2;

            listaHistorico.Insert(0, "Soma: " +  resultado);

            return resultado;
        }

        public decimal subtrair (decimal num1, decimal num2)
        {
            decimal resultado = num1 - num2;

            listaHistorico.Insert(0, "Subtração: " + resultado);

            return resultado;
        }

        public decimal multiplicar (decimal num1, decimal num2)
        {
            decimal resultado = num1 * num2;

            listaHistorico.Insert(0, "Multiplicação: " + resultado);

            return resultado;
        }

        public decimal dividir (decimal num1, decimal num2)
        {
            decimal resultado = num1 / num2;

            listaHistorico.Insert(0, "Divisão: " + resultado);

            return resultado;
        }

        public List<string> historico()
        {
            List<string> resultado;

            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }
    }
}
