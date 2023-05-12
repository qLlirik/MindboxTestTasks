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
    public class CircleTest
    {
        [TestMethod]
        public void CircleArea_UsuallParam()
        {
            var circle = new Circle(3);
            Assert.IsTrue(circle.Area() == 28.274333882308138);
        }

        [TestMethod]
        public void CircleArea_ParamIsNumberOne()
        {
            var circle = new Circle(1);
            Assert.IsTrue(circle.Area() == Math.PI);
        }

        [TestMethod]
        public void CircleArea_ZeroParam()
        {
            var circle = new Circle(0);
            Assert.IsTrue(circle.Area() == 0);
        }
    }
}
