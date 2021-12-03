using NUnit.Framework;

using Ceaser_cipher;

namespace CeaserTest
{
    public class Tests
    {
       

        [Test]
        public void encryptng_message()
        {
            var ceaser = new Ceaser() ;
           string encrypt= ceaser.encrypt("Hello World", 3);
           Assert.AreEqual(encrypt, "khoor zruog");

        }
    }
}