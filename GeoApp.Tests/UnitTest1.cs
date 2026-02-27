using Xunit;
using GeoApp.Core;

namespace GeoApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAreaRectangulo()
        {
            double resultado = Calculadora.AreaRectangulo(10, 5);
            Assert.Equal(50, resultado);
        }
    }
}
