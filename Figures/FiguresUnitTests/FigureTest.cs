using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresUnitTests
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void FigureArea_WithoutSpecificFigure() //For comment from task - Вычисление площади фигуры без знания типа фигуры в compile-time
        {
            var rndValue = new Random().Next(1, 3);
            Figure nonSpecificFigure = null;
            switch (rndValue)
            {
                case 1: { nonSpecificFigure = new Triangle(3, 4, 5); break; }
                case 2: { nonSpecificFigure = new Circle(3); break; }
            }

            var figureArea = nonSpecificFigure.Area();
            Assert.IsNotNull(figureArea);
        }

        [TestMethod]
        public void FigureType_TriangleIsNotRectangle() //For comment from task - Проверку на то, является ли треугольник прямоугольным
        {
            var triangle = new Triangle(3, 4, 5);
            var rectangle = new Rectangle(3, 4);

            Assert.IsFalse(triangle.Equals(rectangle));
        }
    }
}
