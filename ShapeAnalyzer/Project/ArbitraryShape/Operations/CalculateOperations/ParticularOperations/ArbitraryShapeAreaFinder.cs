using System;
using System.Numerics;

namespace ShapeAnalyzer.Project.ArbitraryShape.Operations.CalculateOperations.ParticularOperations
{
    public class ArbitraryShapeAreaFinder : ICalculateOperation
    {
        private readonly Vector2[] _coordinates;

        public ArbitraryShapeAreaFinder(params Vector2[] coordinates)
        {
            _coordinates = coordinates;
        }

        public double Calculate()
        {
            double area = 0;
            area = FindAreaByGausFormula(area);

            return area;
        }

        private double FindAreaByGausFormula(double area)
        {
            for (int j = 0; j < _coordinates.Length; j++)
            {
                area += 0.5 * Math.Abs(_coordinates[j + 1].Y * _coordinates[j].X - _coordinates[j + 1].X * _coordinates[j].Y);
            }

            return area;
        }
    }
}