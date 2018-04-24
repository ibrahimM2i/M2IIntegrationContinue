using IntegrationContinue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
	[TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(Calcul.GetInt("20"));
            Assert.AreEqual(Calcul.GetInt("40"), 40);
            Assert.AreEqual(Calcul.GetInt("50"), 50);
            Assert.AreEqual(Calcul.GetInt("1000"), 1000);
        }

		//[TestMethod]
		//public void TestValue()
		//{
		//	string str = "42";
		//	var Myint = CGetInt(str);

		//	Assert.AreEqual(42, Myint);
		//}

		//[TestMethod]
		//public void TestType()
		//{
		//	string str = "42";
		//	var Myint = Calcul.GetInt(str);

		//	Assert.IsInstanceOfType(Myint, typeof(int));
		//}
	}
}
