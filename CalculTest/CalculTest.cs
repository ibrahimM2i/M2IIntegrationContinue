using System;
using IntegrationContinue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculTest
{
	[TestClass]
	public class CalculTest
	{
		[TestMethod]
		public void TestValue()
		{
			string str = "42";
			var Myint = Calcul.GetInt(str);

			Assert.AreEqual(42, Myint);
		}

		[TestMethod]
		public void TestType()
		{
			string str = "42";
			var Myint = Calcul.GetInt(str);

			Assert.IsInstanceOfType( Myint,typeof(int));
		}
	}
}
