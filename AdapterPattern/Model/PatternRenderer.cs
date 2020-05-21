using System.Collections.Generic;

namespace AdapterPattern.Model
{
    public class PatternRenderer
    {
        private readonly IDataPatternRendererAdapter _dataPatternRenderer;

        public PatternRenderer()
        {
            _dataPatternRenderer = new DataPatternRenderer();
        }

        public PatternRenderer(IDataPatternRendererAdapter dataPatternRenderer)
        {
            _dataPatternRenderer = dataPatternRenderer;
        }

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            return _dataPatternRenderer.ListPatterns(patterns);
        }
    }
}
