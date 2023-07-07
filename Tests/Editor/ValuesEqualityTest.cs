using NUnit.Framework;

namespace Kukumberman.SecuredVariables.Tests
{
    public sealed class ValuesEqualityTest
    {
        [Test]
        public void Int32()
        {
            int value = 146;
            SecuredInt32 secured = value;
            Assert.AreEqual(value, secured.Value);
        }

        [Test]
        public void Int64()
        {
            long value = 146;
            SecuredInt64 secured = value;
            Assert.AreEqual(value, secured.Value);
        }

        [Test]
        public void Float32()
        {
            float value = 146.146f;
            SecuredFloat32 secured = value;
            Assert.AreEqual(value, secured.Value);
        }

        [Test]
        public void String()
        {
            string value = "Kukumberman";
            SecuredString secured = value;
            Assert.AreEqual(value, secured.Value);
        }
    }
}
