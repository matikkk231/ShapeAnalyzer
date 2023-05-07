using System;

namespace ShapeAnalyzer.Project.Test_ShapeService
{
    public interface ICheckableAnalyzator<T> where T : Enum
    {
        public bool DoCheck(T particularCheckType);
    }
}