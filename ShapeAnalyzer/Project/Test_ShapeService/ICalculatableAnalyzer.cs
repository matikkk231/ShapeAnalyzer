using System;

namespace ShapeAnalyzer.Project.Test_ShapeService
{
    public interface ICalculatableAnalyzer<T> where T : Enum
    {
        public double DoCalculation(T particularCalculationType);
    }
}