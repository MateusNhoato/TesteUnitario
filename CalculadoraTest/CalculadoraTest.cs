using TesteUnitario;

namespace CalculadoraTest
{
    public class CalculadoraTest
    {
        private Calculadora alvoDoTeste = new Calculadora();


        [Theory]
        [Trait("Calculadora", "Soma")]
        [InlineData(10, 3, 7)]
        [InlineData(24, 5, 19)]
        [InlineData(30, 23, 7)]
        [InlineData(-55, -60, 5)]
        [InlineData(300, 150, 150)]
        public void SomaDeDoisValoresRetornaValor
            (double esperado,
            double valor1,
            double valor2)
        {
            // Act
            double resultado = alvoDoTeste.Somar(valor1, valor2);
            // Assert
            Assert.Equal(esperado, resultado);
        }
        [Theory]
        [Trait("Calculadora", "Subtração")]
        [InlineData(-4, 3, 7)]
        [InlineData(-14, 5, 19)]
        [InlineData(16, 23, 7)]
        [InlineData(-65, -60, 5)]
        [InlineData(0, 150, 150)]
        public void SubtrairDoisValoresRetornaValor
            (double esperado,
            double valor1,
            double valor2)
        {
            // Act
            double resultado = alvoDoTeste.Subtrair(valor1, valor2);
            // Assert
            Assert.Equal(esperado, resultado);
        }
        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(50, 5, 10)]
        [InlineData(1000, 10, 100)]
        [InlineData(-44, 22, -2)]
        public void MultiplicacaoDeDoisValoresRetornaValor
            (double esperado, 
             double valor1, 
             double valor2)
        {         
            double resultado = alvoDoTeste.Multiplicar(valor1, valor2);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(2, 10, 5)]
        [InlineData(0.5, 5, 10)]
        [InlineData(10, 100, 10)]
        [InlineData(11, -22, -2)]
        public void DivisaoDeDoisValoresRetornaValor
            (double esperado,
             double valor1,
             double valor2)
        {
            double resultado = alvoDoTeste.Dividir(valor1, valor2);
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void DivisaoDeValorPorZeroRetornaErro()
        {
            Assert.Throws<DivideByZeroException>(() => alvoDoTeste.Dividir(10, 0));
        }
    }
}