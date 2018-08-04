using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQl
{
    /// <summary>
    /// Initially, I wasn't going to contain Fragments:
    /// this doesn't contain a reference for a Fragment because that doesn't
    /// add any value to this... The resultant json query could be optimized in
    /// a post processing step.
    ///
    /// However, Fragments can be useful for defining results on when the query
    /// results in different types being returned
    /// (http://facebook.github.io/graphql/June2018/#example-a6b78)
    /// </summary>
    public sealed class SelectionSet : GraphQlPart
    {
        public override GraphQlPartType PartType { get; } = GraphQlPartType.SelectionSet;

        public SelectionSet(IEnumerable<Field> fields, IEnumerable<Fragment> fragments)
        {
            this.fields = fields.ToList();
            this.fragments = fragments.ToList();
        }

        private readonly IList<Field> fields;
        public IEnumerable<Field> Fields => fields.ToList();

        private readonly IList<Fragment> fragments;
        public IEnumerable<Fragment> Fragments => fragments.ToList();

        public static SelectionSet Empty()
        {
            return new SelectionSet(Enumerable.Empty<Field>(), Enumerable.Empty<Fragment>());
        }

        internal void AddField(Field field)
        {
            this.fields.Add(field);
        }
    }    
}
