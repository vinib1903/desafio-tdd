using desafio_tdd;

namespace desafio_tdd_tests;

public class CalculadoraTests
{
    public Calculadora ConstruirClasse ()
    {
        DateTime data = DateTime.Today;
        Calculadora calc = new(data);

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 6, 10)]
    public void RecebeDoisNumerosERetornaASoma(int num1, int num2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Somar(num1, num2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(10, 5, 5)]
    public void RecebeDoisNumerosERetornaASubtracao(int num1, int num2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Subtrair(num1, num2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(4, 2, 8)]
    [InlineData(10, 5, 50)]
    public void RecebeDoisNumerosERetornaAMultiplicacao(int num1, int num2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Multiplicar(num1, num2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(10, 5, 2)]
    public void RecebeDoisNumerosERetornaADivisao(int num1, int num2, int res)
    {
        Calculadora calc = ConstruirClasse();

        int resultado = calc.Dividir(num1, num2);

        Assert.Equal(res, resultado);
    }

    [Fact]
    public void ReeccebeUmNumeroEDividePorZeroDeveRetornarExcecao ()
    {
        Calculadora calc = ConstruirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    public void TestaORetornoDoHistorico()
    {
        Calculadora calc = ConstruirClasse();

        calc.Somar(1, 2);
        calc.Subtrair(4, 2);
        calc.Multiplicar(3, 3);
        calc.Dividir(10, 5);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count - 3);
    }
}