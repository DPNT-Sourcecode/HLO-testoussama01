using BeFaster.App.Solutions.HLO;
using BeFaster.App.Solutions.SUM;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("oussama", ExpectedResult = "Hello oussama")]
        public string SayHello(string name)
        {
            return HelloSolution.Hello(name);
        }
    }
}
