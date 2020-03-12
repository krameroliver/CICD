using System;
using CICD;
using NUnit.Framework;

namespace CICD_UTs
{
    [TestFixture]
    public class WriterTests
    {
        [Test]
        public void WRITER_output_Hello_Test()
        {
            WRITER w = new WRITER();
            w.out_writer="Hello";
            
            Assert.True(w.out_writer=="HELLO");
        }
    }
}