using Ueb11a_Strassenverkehrsamt;

namespace Ueb11a_StrassenverkehrsamtTest
{
    // Die Testklasse f�r die Person
    [TestClass]
    public class UnitTestPerson
    {
        [TestMethod]
        public void TesteMethode_Konstrutor()
        {
            Person p = new Person();

            Assert.IsTrue(true);
        }
    }
}