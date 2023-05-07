using System;

namespace ShapeAnalyzer.Project
{
    public interface ICalculatableAnalyzer<T> where T : Enum
    {
        public double DoCalculation(T particularCalculationType);
    }
}