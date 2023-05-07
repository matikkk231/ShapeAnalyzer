using System;
using System.Numerics;

namespace ShapeAnalyzer.Project.ArbitraryShape.Operations.CalculateOperations.ParticularOperations
{
    public class ArbitraryShapeAreaFinder : ICalculateOperation
    {
        private readonly Vector2[] _coordinates;

        public ArbitraryShapeAreaFinder(Vector2[] coordinates)
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
            var border = _coordinates.Length - 1;
            for (int j = 0; j <= border; j++)
            {
                if (j == border)
                {
                    var firstPeak = 0;
                    area += _coordinates[firstPeak].Y * _coordinates[j].X - _coordinates[firstPeak].X * _coordinates[j].Y;
                }
                else
                {
                    area += _coordinates[j + 1].Y * _coordinates[j].X - _coordinates[j + 1].X * _coordinates[j].Y;
                }
            }

            area /= 2;

            return Math.Abs(area);
        }
    }
}