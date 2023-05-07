namespace ShapeAnalyzer.Project.Test_ShapeService.Triangle.Operations.CheckOperations.ParticularOperations
{
    internal class TriangleRectInspectOperation : ICheckOperation
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public TriangleRectInspectOperation(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public bool Check()
        {
            bool isTriangleRectengular = false;

            if (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC)
            {
                isTriangleRectengular = true;
            }

            if (_sideA * _sideA + _sideC * _sideC == _sideB * _sideB)
            {
                isTriangleRectengular = true;
            }

            if (_sideB * _sideB + _sideC * _sideC == _sideA * _sideA)
            {
                isTriangleRectengular = true;
            }

            return isTriangleRectengular;
        }
    }
}