using System.Collections.Generic;
using ShapeAnalyzer.Project.Cycle.Operations;
using ShapeAnalyzer.Project.Cycle.Operations.CalculateOperations;

namespace ShapeAnalyzer.Project.Cycle
{
    public class CycleAnalyzer : ICalculatableAnalyzer<CycleCaclculateOperationTypes>
    {
        private readonly Dictionary<CycleCaclculateOperationTypes, ICalculateOperation> _calculateOperations = new();

        public CycleAnalyzer(double radius)
        {
            _calculateOperations.Add(CycleCaclculateOperationTypes.FindingСircumference, new CircumferenceFinder(radius));
        }

        public double DoCalculation(CycleCaclculateOperationTypes particularCalculationType)
        {
            return _calculateOperations[particularCalculationType].Calculate();
        }
    }
}