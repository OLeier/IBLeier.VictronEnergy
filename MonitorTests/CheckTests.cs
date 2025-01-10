using IBLeier.VictronEnergy.Monitor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Monitor.Tests
{
    [TestClass()]
    public class CheckTests
    {
        [TestMethod()]
        public void CheckVoltageTest()
        {
            double bv = 26.01;
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