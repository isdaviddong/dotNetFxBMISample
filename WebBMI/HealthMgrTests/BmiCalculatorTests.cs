using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthMgr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMgr.Tests
{
    [TestClass()]
    public class BmiCalculatorTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            HealthMgr.BmiCalculator bmi = new HealthMgr.BmiCalculator();
            bmi.Height = 170;
            bmi.Weight = 70;

            var result = bmi.Calculate();

            Assert.AreEqual("24.22", result.ToString("00.00"));
        }
    }
}