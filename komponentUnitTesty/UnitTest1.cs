using Bunit;
using komponentProjekt.Pages;

namespace komponentUnitTesty
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void TestAddNumbers()
        {
            // Arrange
            var component = new KalkulatorKomponent();
            component.num1 = "2";
            component.num2 = "3";

            // Act
            component.AddNumbers();

            // Assert
            Assert.Equal("5", component.finalresult);
        }
        [Fact]
        public void TestSubtractNumbers()
        {
            // Arrange
            var component = new KalkulatorKomponent();
            component.num1 = "2";
            component.num2 = "3";

            // Act
            component.SubtractNumbers();

            // Assert
            Assert.Equal("-1", component.finalresult);
        }
        [Fact]
        public void TestMultiplyNumbers()
        {
            // Arrange
            var component = new KalkulatorKomponent();
            component.num1 = "3";
            component.num2 = "3";

            // Act
            component.MultiplyNumbers();

            // Assert
            Assert.Equal("9", component.finalresult);
        }
        [Fact]
        public void Test_BackgroundColor()
        {
            // Arrange
            var component = RenderComponent<BackgroundKomponent>();

            // Act
            component.Instance.backgroundColor();

            // Assert
            Assert.Equal("black", component.Instance.bckReal);
        }
    }
}