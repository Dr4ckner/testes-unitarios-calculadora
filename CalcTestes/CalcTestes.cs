using System.Linq.Expressions;
using Calc.Services;

namespace CalcTestes;

public class CalcTestes
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5 , 9)]
    public void CalcularSoma(int n1, int n2, int resultado)
    {
        // Given
        CalculadoraImp calc = new CalculadoraImp();
        int resultadocalc = calc.Somar(n1, n2);
        // Act
    
        // Assert
        Assert.Equal(resultado, resultadocalc);
        
    }
    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 5 , 0)]
    public void CalcularSubtracao(int n1, int n2, int resultado)
    {
        // Given
        CalculadoraImp calc = new CalculadoraImp();
        int resultadocalc = calc.Subtrair(n1, n2);
        // Act
    
        // Assert
        Assert.Equal(resultado, resultadocalc);
        
    }
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5 , 20)]
    public void CalcularMultiplicao(int n1, int n2, int resultado)
    {
        // Given
        CalculadoraImp calc = new CalculadoraImp();
        int resultadocalc = calc.Multiplicar(n1, n2);
        // Act
    
        // Assert
        Assert.Equal(resultado, resultadocalc);
        
    }
    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(9, 3 , 3)]
    public void CalcularDivisao(int n1, int n2, int resultado)
    {
        // Given
        CalculadoraImp calc = new CalculadoraImp();
        int resultadocalc = calc.Dividir(n1, n2);
        // Act
    
        // Assert
        Assert.Equal(resultado, resultadocalc);
        
    }
    [Fact]
    public void TestarHistorico()
    {
        CalculadoraImp calc = new CalculadoraImp();

        calc.Somar(2, 3);
        calc.Somar(3, 3);
        calc.Somar(5, 3);
        calc.Somar(6, 3);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}