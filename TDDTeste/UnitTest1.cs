using System.ComponentModel;
using System.Runtime.InteropServices;
using TDD_e_Testes_unitarios;

namespace TDDTeste
{
    public class UnitTest1
    {
        [Fact]
        public void TesteSomar1()
        {
            Calculadora calc = new Calculadora();

            decimal resultado = calc.somar(2, 2);

            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(8, 2, 10)]
        public void TesteSomar2(decimal num1, decimal num2, decimal resultado)
        {
            Calculadora calc = new Calculadora();

            decimal resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(8, 9, -1)]
        public void TesteSubtrair(decimal num1, decimal num2, decimal resultado)
        {
            Calculadora cal = new Calculadora();

            decimal resultadoCalculadora = cal.subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(8, 2, 16)]
        public void TesteMultiplicar(decimal num1, decimal num2, decimal resultado)
        {
            Calculadora cal = new Calculadora();

            decimal resultadoCalculadora = cal.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 2.5)]
        [InlineData(8, 2, 4)]
        public void TesteDividir(decimal num1, decimal num2, decimal resultado)
        {
            Calculadora cal = new Calculadora();

            decimal resultadoCalculadora = cal.dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDivisaoPor0()
        {
            Calculadora cal = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => cal.dividir(2, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            Calculadora cal = new Calculadora();
            cal.somar(2, 4);
            cal.dividir(4, 5);
            cal.multiplicar(2, 6);
            cal.subtrair(6, 2);

            var lista = cal.historico();

            Assert.NotEmpty(cal.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}