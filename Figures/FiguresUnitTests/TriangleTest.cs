using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresUnitTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleArea_UsuallParams()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.Area() == 6);
        }

        [TestMethod]
        public void TriangleArea_OneZeroParam()
        {
            var triangle = new Triangle(0, 4, 5);
            Assert.IsTrue(double.IsNaN(triangle.Area()));
        }

        [TestMethod]
        public void TriangleArea_AllZeroParams()
        {
            var triangle = new Triangle(0, 0, 0);
            Assert.IsTrue(triangle.Area() == 0);
        }
    }
}
