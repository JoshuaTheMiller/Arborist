using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQl.QueryConverter
{
    public sealed class GraphQlQueryConvertOrchestrator
    {
        private readonly IDictionary<GraphQlPartType, IGraphQlConverter> converters = new Dictionary<GraphQlPartType, IGraphQlConverter>();

        public GraphQlQueryConvertOrchestrator(IEnumerable<IGraphQlConverter> converters)
        {
            foreach(var converter in converters)
            {
                this.converters.Add(converter.SupportedType, converter);
            }
        }

        public string Convert(GraphQlPart part)
        {
    
        }
    }
}
