using System;
using System.Collections.Generic;
using System.Numerics;
using ShapeAnalyzer.Project.Triangle.Operations.CalculateOperations;
using ShapeAnalyzer.Project.Triangle.Operations.CalculateOperations.ParticularOperations;
using ShapeAnalyzer.Project.Triangle.Operations.CheckOperations;
using ShapeAnalyzer.Project.Triangle.Operations.CheckOperations.ParticularOperations;

namespace ShapeAnalyzer.Project.Triangle
{
    public class TriangleAnalyzer : ICalculatableAnalyzer<TriangleCalculateOperationTypes>, ICheckableAnalyzator<TriangleCheckOperationTypes>
    {
        private readonly Dictionary<TriangleCalculateOperationTypes, ICalculateOperation> _calculateOperations = new();
        private readonly Dictionary<TriangleCheckOperationTypes, ICheckOperation> _checkOperations = new();

        public TriangleAnalyzer(double sideA, double sideB, double sideC)
        {
            FillCalculateOperations(_calculateOperations, sideA, sideB, sideC);
            FillCheckOperations(_checkOperations, sideA, sideB, sideC);
        }

        public TriangleAnalyzer(Vector2 coordinateA, Vector2 coordinateB, Vector2 coordinateC)
        {
            var sides = ConvertCoordinatesToSides(coordinateA, coordinateB, coordinateC);

            FillCalculateOperations(_calculateOperations, sides.sideA, sides.sideB, sides.sideC);
            FillCheckOperations(_checkOperations, sides.sideA, sides.sideB, sides.sideC);
        }

        public double DoCalculation(TriangleCalculateOperationTypes particularCalculationType)
        {
            return _calculateOperations[particularCalculationType].Calculate();
        }

        public bool DoCheck(TriangleCheckOperationTypes particularCheckType)
        {
            return _checkOperations[particularCheckType].Check();
        }

        private void FillCalculateOperations(Dictionary<TriangleCalculateOperationTypes, ICalculateOperation> calculateOperations, double sideA, double sideB, double sideC)
        {
            calculateOperations.Add(TriangleCalculateOperationTypes.FindArea, new TriangleAreaFinder(sideA, sideB, sideC));
        }

        private void FillCheckOperations(Dictionary<TriangleCheckOperationTypes, ICheckOperation> checkOperations, double sideA, double sideB, double sideC)
        {
            checkOperations.Add(TriangleCheckOperationTypes.IsTriangleRectangular, new TriangleRectangularityInspector(sideA, sideB, sideC));
        }

        private (double sideA, double sideB, double sideC) ConvertCoordinatesToSides(Vector2 coordinateA, Vector2 coordinateB, Vector2 coordinateC)
        {
            var sideA = Math.Sqrt((coordinateB.X - coordinateA.X) * (coordinateB.X - coordinateA.X) + (coordinateB.Y - coordinateA.Y) * (coordinateB.Y - coordinateA.Y));
            var sideB = Math.Sqrt((coordinateC.X - coordinateB.X) * (coordinateC.X - coordinateB.X) + (coordinateC.Y - coordinateB.Y) * (coordinateC.Y - coordinateB.Y));
            var sideC = Math.Sqrt((coordinateA.X - coordinateC.X) * (coordinateA.X - coordinateC.X) + (coordinateA.Y - coordinateC.Y) * (coordinateA.Y - coordinateC.Y));

            return (sideA, sideB, sideC);
        }
    }
}