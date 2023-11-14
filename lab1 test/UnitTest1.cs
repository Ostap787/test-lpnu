using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections;

namespace AnalizerClassLibraryTest
{
    [TestClass]
    public class YourClassTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient", "Data Source=T3500;Initial Catalog=lab1;Integrated Security=True;", "YourEntities", DataAccessMethod.Sequential)]
        public void TestSeparateMethod()
        {
            string testInput = TestContext.DataRow["TestInput"].ToString();
            string expectedOutput = TestContext.DataRow["ExpectedOutput"].ToString();

            List<string> result = AnalizerClass.Separate(testInput).ToList();

            CollectionAssert.AreEqual(expectedOutput.Split(','), result);
        }
    }
}
