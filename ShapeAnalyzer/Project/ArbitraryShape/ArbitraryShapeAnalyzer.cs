using System.Collections.Generic;
using System.Numerics;
using ShapeAnalyzer.Project.ArbitraryShape.Operations.CalculateOperations;
using ShapeAnalyzer.Project.ArbitraryShape.Operations.CalculateOperations.ParticularOperations;

namespace ShapeAnalyzer.Project.ArbitraryShape
{
    public class ArbitraryShapeAnalyzer : ICalculatableAnalyzer<ArbitraryShapeCalculateTypes>
    {
        private readonly Dictionary<ArbitraryShapeCalculateTypes, ICalculateOperation> _calculateOperations = new();

        public ArbitraryShapeAnalyzer(params Vector2[] coordinates)
        {
            _calculateOperations.Add(ArbitraryShapeCalculateTypes.FindingArea, new ArbitraryShapeAreaFinder(coordinates));
        }

        public double DoCalculation(ArbitraryShapeCalculateTypes particularCalculationType)
        {
            return _calculateOperations[particularCalculationType].Calculate();
        }
    }
}