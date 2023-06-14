using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradebook.DAL;

namespace GradebookTest.DAL
{
    public class TestHashing
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldHashPasswordTheSameWayEachTime()
        {
            var bytes = new UTF8Encoding().GetBytes("testing");
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            Assert.That(Convert.ToBase64String(hashBytes), Is.EqualTo(Hashing.HashPassword("testing")));
        }


    }
}
