using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void Test1() // Cambiá el nombre para indicar qué estás probando
        {
            Person Franco = new Person("Franco","5.308.038-6");
            IdUtils.IdIsValid(Franco.ID);
        }

        [Test]
        public void Test2() // Cambiá el nombre para indicar qué estás probando
        {
            Person Mateo = new Person("Franco","4.308.038-6");
            IdUtils.IdIsValid(Mateo.ID);
        }

        public void Test3() // Cambiá el nombre para indicar qué estás probando
        {
            Person Franco = new Person("Franco","5.308.038-6");
            IdUtils.IdIsValid(Franco.ID);
        }

    }
}