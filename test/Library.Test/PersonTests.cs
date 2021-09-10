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
            Person Mateo = new Person("Franco",".308.038-6");
            IdUtils.IdIsValid(Mateo.ID);
        }

        public void Test3() // Cambiá el nombre para indicar qué estás probando
        {
            Person Franco = new Person("Franco","5.3a8.038-6");
            IdUtils.IdIsValid(Franco.ID);
        }

        public void Test4() // Cambiá el nombre para indicar qué estás probando
        {
            Person Franco = new Person("Franco","5.22238.038-6");
            IdUtils.IdIsValid(Franco.ID);
        }

        public void Test5() // Cambiá el nombre para indicar qué estás probando
        {
            Person Franco = new Person("Franco"," ");
            IdUtils.IdIsValid(Franco.ID);
        }

        public void Test6() // Cambiá el nombre para indicar qué estás probando
        {
            Person Franco = new Person("Franco","5.308.038-10");
            IdUtils.IdIsValid(Franco.ID);
        }

    }
}