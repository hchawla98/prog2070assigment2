using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG2070Assignment2;

namespace PROG2070Assignment2.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void EquilateralTriangle()
        {
            NUnit.Framework.Assert.AreEqual(7, 7, 7, TriangleSolver.Analyze(7, 7, 7));
        }


        [Test]
        public void ScaleneTriangle()
        {
            NUnit.Framework.Assert.AreEqual(7, 8, 9, TriangleSolver.Analyze(7, 8, 9));
        }
        [Test]
        public void IsoscelesTriangle()
        {
            NUnit.Framework.Assert.AreEqual(7, 6, 6, TriangleSolver.Analyze(5, 7, 7));
        }
        [Test]
        public void TriangleNotFormed()
        {
            NUnit.Framework.Assert.AreEqual(0, 0, 0, TriangleSolver.Analyze(4, 1, 2));
        }
        [Test]
        public void TriangleFormed()
        {
            NUnit.Framework.Assert.AreEqual(1, 2, 3, TriangleSolver.Analyze(3, 4, 5));
        }
        [Test]
        public void EquiangularTriangle()
        {
            NUnit.Framework.Assert.AreEqual(4, 4, 4, TriangleSolver.Analyze(5, 5, 5));
        }
    }
}
