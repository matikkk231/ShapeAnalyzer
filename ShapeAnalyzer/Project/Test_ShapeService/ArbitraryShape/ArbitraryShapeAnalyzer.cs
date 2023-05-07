using System.Collections.Generic;
using System.Numerics;
using ShapeAnalyzer.Project.Test_ShapeService.ArbitraryShape.Operations.CalculateOperations;
using ShapeAnalyzer.Project.Test_ShapeService.ArbitraryShape.Operations.CalculateOperations.ParticularOperations;

namespace ShapeAnalyzer.Project.Test_ShapeService.ArbitraryShape
{
    public class ArbitraryShapeAnalyzer : ICalculatableAnalyzer<ArbitraryShapeCalculateTypes>
    {
        private readonly Dictionary<ArbitraryShapeCalculateTypes, ICalculateOperation> _calculateOperations = new();

        public ArbitraryShapeAnalyzer(Vector2[] coordinates)
        {
            _calculateOperations.Add(ArbitraryShapeCalculateTypes.FindingArea, new ArbitraryShapeAreaFindOperation(coordinates));
        }

        public double DoCalculation(ArbitraryShapeCalculateTypes particularCalculationType)
        {
            return _calculateOperations[particularCalculationType].Calculate();
        }
    }
}