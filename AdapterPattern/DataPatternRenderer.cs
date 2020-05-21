using System.Collections.Generic;
using System.IO;
using AdapterPattern.Library;
using AdapterPattern.Model;

namespace AdapterPattern
{
    public class DataPatternRenderer : IDataPatternRendererAdapter
    {
        private DataRenderer _dataRenderer;

        public string ListPatterns(IEnumerable<Pattern> patterns)
        {
            var adapter = new PatternCollectionDbAdapter(patterns);

            _dataRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            _dataRenderer.Render(writer);

            return writer.ToString();
        }
    }
}
