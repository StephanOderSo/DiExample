using DiExampleConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    [TestClass]
    public class UnitTestClient
    {
        [TestMethod]
        public void GetValue_Ok()
        {
            try
            {

                ConsoleLogger cLogger = new();
                Client client = new(cLogger);

                int? value = client.GetValue("a").Result;

                Assert.IsTrue(value > 0);
                
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }

        }

        [TestMethod]
        public void GetValue_NoValue()
        {
            try
            {

                ConsoleLogger cLogger = new();
                Client client = new(cLogger);

                int? value = client.GetValue("b").Result;

                Assert.IsTrue(value < 0);

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }

        }
    }
}
