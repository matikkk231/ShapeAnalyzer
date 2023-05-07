using System;

namespace ShapeAnalyzer.Project.Triangle.Operations.CalculateOperations.ParticularOperations
{
    internal class TriangleAreaFinder : ICalculateOperation
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public TriangleAreaFinder(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double Calculate()
        {
            return FindAreaByGeronFormula();
        }

        private double FindAreaByGeronFormula()
        {
            var halfPerimeter = (_sideA + _sideB + _sideC) / 2;
            var area = Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
            return area;
        }
    }
}