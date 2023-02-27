namespace TesteUnitario
{
    public class Calculadora
    {
        public double Somar(double valor1, double valor2) 
                            => valor1 + valor2;
        public double Subtrair(double valor1, double valor2)
                             => valor1 - valor2;

        public double Multiplicar(double valor1, double valor2)
                            => valor1 * valor2;

        public double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
                throw new DivideByZeroException("Divisao por zero");
            return valor1 / valor2;
        }
    }
}
