using System;

namespace ShapeAnalyzer.Project.Cycle.Operations.CalculateOperations
{
    internal class CircumferenceFindOperation : ICalculateOperation
    {
        private readonly double _radius;

        public CircumferenceFindOperation(double radius)
        {
            _radius = radius;
        }

        public double Calculate()
        {
            var circumference = 2 * Math.PI * _radius;
            return circumference;
        }
    }
}