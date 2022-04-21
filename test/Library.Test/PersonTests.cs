using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {   
        }

        [Test]
        public void ValidId() 
        {
            Person validId = new Person("John Doe", "5.274.086-0");
            string expected = "5.274.086-0";
            Assert.AreEqual(expected, validId.ID);
        }
        [Test]
        public void InvalidId() 
        {
            Person invalidId = new Person("John Doe", "5.274.086-8");
            Assert.IsNull(invalidId.ID);
        }
        [Test]
        public void InvalidName() 
        {
            Person invalidName = new Person("", "5.274.086-0");
            Assert.IsNull(invalidName.Name);
        }
        [Test]
        public void ValidName() 
        {
            Person validName = new Person("John Doe", "5.274.086-0");
            string expected = "John Doe";
            Assert.AreEqual(expected, validName.Name);
        }
    }
}