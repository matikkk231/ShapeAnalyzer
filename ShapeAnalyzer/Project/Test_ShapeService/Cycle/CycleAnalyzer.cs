using System.Collections.Generic;
using ShapeAnalyzer.Project.Test_ShapeService.Cycle.Operations;
using ShapeAnalyzer.Project.Test_ShapeService.Cycle.Operations.CalculateOperations;

namespace ShapeAnalyzer.Project.Test_ShapeService.Cycle
{
    public class CycleAnalyzer : ICalculatableAnalyzer<CycleCaclculateOperationTypes>
    {
        private readonly Dictionary<CycleCaclculateOperationTypes, ICalculateOperation> _calculateOperations = new();

        public CycleAnalyzer(double radius)
        {
            _calculateOperations.Add(CycleCaclculateOperationTypes.FindingСircumference, new CircumferenceFindOperation(radius));
        }

        public double DoCalculation(CycleCaclculateOperationTypes particularCalculationType)
        {
            return _calculateOperations[particularCalculationType].Calculate();
        }
    }
}