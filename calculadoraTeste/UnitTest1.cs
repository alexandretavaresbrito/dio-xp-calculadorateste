using calculadora.Services;

namespace calculadoraTeste;

public class UnitTest1
{
    CalculadoraServices _calc = new CalculadoraServices();

    [Theory]
    [InlineData(3, 2, 5)]
    [InlineData(10, 5, 15)]
    public void somarTest( int a, int b, int res)
    {
        // Act
        int resultado = _calc.Somar(a, b);
        //Arrange
        Assert.Equal(res, resultado);

    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(5, 5, 0)]
    public void subtrairTest( int a, int b, int res)
    {
        // Act
        int resultado = _calc.Subtrair(a, b);
        //Arrange
        Assert.Equal(res, resultado);

    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(10, 5, 2)]
    public void dividirTest( int a, int b, int res)
    {
        // Act
        int resultado = _calc.Dividir(a, b);
        //Arrange
        Assert.Equal(res, resultado);

    }

    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(10, 5, 50)]
    public void multiplicarTest( int a, int b, int res)
    {
        // Act
        int resultado = _calc.Multiplicar(a, b);
        //Arrange
        Assert.Equal(res, resultado);

    }
}