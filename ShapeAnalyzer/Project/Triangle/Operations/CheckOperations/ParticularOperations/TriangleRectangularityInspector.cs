namespace ShapeAnalyzer.Project.Triangle.Operations.CheckOperations.ParticularOperations
{
    internal class TriangleRectangularityInspector : ICheckOperation
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public TriangleRectangularityInspector(double sideA, double sideB, double sideC)
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