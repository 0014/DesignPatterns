using System.Collections.Generic;
using AdapterPattern.Model;

namespace AdapterPattern
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}