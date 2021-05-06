using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Tests
{
	[TestClass()]
	public class CheckTests
	{
		[TestMethod()]
		public void CheckVoltageTest()
		{
			double bv = 24.81;
			Check check = Check.CheckVoltage(bv);
			Assert.IsNull(check, bv.ToString());

			bv = 24.79;
			check = Check.CheckVoltage(bv);
			Assert.IsNotNull(check, bv.ToString());
			Assert.AreEqual(24.8, check.low);

			//bv = 24.79;
			check = Check.CheckVoltage(bv);
			Assert.IsNull(check, bv.ToString());

			bv = 24.19;
			check = Check.CheckVoltage(bv);
			Assert.IsNotNull(check, bv.ToString());
			Assert.AreEqual(24.2, check.low);

			bv = 24.21;
			check = Check.CheckVoltage(bv);
			Assert.IsNull(check, bv.ToString());

			bv = 24.51;
			check = Check.CheckVoltage(bv);
			Assert.IsNull(check, bv.ToString());

			bv = 24.49;
			check = Check.CheckVoltage(bv);
			Assert.IsNull(check, bv.ToString());

			bv = 24.66;
			check = Check.CheckVoltage(bv);
			Assert.IsNull(check, bv.ToString());

			bv = 24.48;
			check = Check.CheckVoltage(bv);
			Assert.IsNotNull(check, bv.ToString());
			Assert.AreEqual(24.5, check.low);
		}
	}
}