using System;
using System.Collections.Generic;
using System.Linq;

namespace GitHubGraphQl
{
    public sealed class QueryBuilder
    {
        
    }

    public class GraphQlBuilder
    {
        private readonly GraphQlNode parentNode;

        public GraphQlBuilder()
        {
            this.parentNode = GraphQlNode.CreateEmpty("query");
        }

        public void AddNode(GraphQlNode node)
        {

        }
    }

    public sealed class GraphQlNode : GraphQlElement
    {
        private readonly IList<GraphQlElement> elements;
        public IEnumerable<GraphQlElement> Elements => elements.ToList();

        public GraphQlNode(string name, IEnumerable<GraphQlElement> elements) : base(name)
        {            
            this.elements = elements.ToList();
        }

        public void Add(GraphQlElement element)
        {
            elements.Add(element);
        }

        public static GraphQlNode CreateEmpty(string name)
        {
            return new GraphQlNode(name, Enumerable.Empty<GraphQlElement>());
        }
    }

    public sealed class GraphQlLeaf : GraphQlElement
    {
        public GraphQlLeaf(string name) : base(name)
        {
        }
    }

    public abstract class GraphQlElement
    {
        protected GraphQlElement(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
