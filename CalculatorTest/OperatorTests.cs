using Calculator;
using System.Collections.Generic;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class Operators
    {
        class OpTester
        {
            public int a;
            public int b;
            public double expected;

            public OpTester(int a, int b, double expected)
            {
                this.a = a;
                this.b = b;
                this.expected = expected;
            }
        }

        [Test]
        public void TestAdd()
        {
            List<OpTester> testCases = new List<OpTester>
            {
                new OpTester(1, 2, 3),
                new OpTester(99, 1, 100)
            };

            foreach (OpTester tc in testCases)
            {
                Assert.AreEqual(Program.Add(tc.a, tc.b), tc.expected);
            }
        }

        [Test]
        public void TestSub()
        {
            List<OpTester> testCases = new List<OpTester>
            {
                new OpTester(1, 2, -1),
                new OpTester(2, 2, 0),
                new OpTester(3, 100, -97)
            };

            foreach (OpTester tc in testCases)
            {
                Assert.AreEqual(Program.Sub(tc.a, tc.b), tc.expected);
            }
        }

        [Test]
        public void TestMul()
        {
            List<OpTester> testCases = new List<OpTester>
            {
                new OpTester(1, 2, 2),
                new OpTester(2, 2, 4),
                new OpTester(3, 100, 300)
            };

            foreach (OpTester tc in testCases)
            {
                Assert.AreEqual(Program.Mul(tc.a, tc.b), tc.expected);
            }
        }

        [Test]
        public void TestFloor()
        {
            List<OpTester> testCases = new List<OpTester>
            {
                new OpTester(1, 2, 0),
                new OpTester(2, 2, 1),
                new OpTester(3, 100, 0)
            };

            foreach (OpTester tc in testCases)
            {
                Assert.AreEqual(Program.Floor(tc.a, tc.b), tc.expected);
            }
        }

        [Test]
        public void TestDiv()
        {
            List<OpTester> testCases = new List<OpTester>
            {
                new OpTester(1, 2, 0.5),
                new OpTester(2, 2, 1),
                new OpTester(3, 2, 1.5)
            };

            foreach (OpTester tc in testCases)
            {
                Assert.AreEqual(Program.Div(tc.a, tc.b), tc.expected);
            }
        }
    }
}
