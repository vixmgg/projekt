using komponentProjekt.Pages;
namespace komponentTesty

{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        public void wrongSymbol()
        {
            var dodawanie = new AddNumbers();
        }
    }
}