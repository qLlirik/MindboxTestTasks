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
    public class RectangleTest
    {
        [TestMethod]
        public void RectangleArea_UsuallParams()
        {
            var rectangle = new Rectangle(3, 4);
            Assert.IsTrue(rectangle.Area() == 12);
        }

        [TestMethod]
        public void RectangleArea_OneZeroParam()
        {
            var rectangle = new Rectangle(0, 4);
            Assert.IsTrue(rectangle.Area() == 0);
        }

        [TestMethod]
        public void RectangleArea_AllZeroParams()
        {
            var rectangle = new Rectangle(0, 0);
            Assert.IsTrue(rectangle.Area() == 0);
        }
    }
}
