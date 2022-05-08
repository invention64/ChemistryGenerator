using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemistryGenerator.Classes.Generators;


namespace GenTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetFile()
        {
            NameGenerator nameGenerator = new NameGenerator();
            // lets make sure the function works, and the list has data
            Assert.IsNotNull(nameGenerator.getPrefixes());
            Assert.IsTrue(nameGenerator.getPrefixes().Count > 1);
        }
    }
}
