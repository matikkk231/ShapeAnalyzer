using System;

namespace ShapeAnalyzer.Project
{
    public interface ICheckableAnalyzator<T> where T : Enum
    {
        public bool DoCheck(T particularCheckType);
    }
}