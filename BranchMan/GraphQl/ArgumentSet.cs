using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQl
{
    public sealed class ArgumentSet
    {
        private readonly IDictionary<string, Argument> arguments = new Dictionary<string, Argument>();

        public ArgumentSet(IEnumerable<Argument> arguments)
        {
            foreach (var argument in arguments)
            {
                this.arguments.Add(argument.Name, argument);
            }
        }        

        public IEnumerable<Argument> GetArguments() => arguments.Select(kvp => kvp.Value).ToList();

        internal static ArgumentSet Empty()
        {
            throw new NotImplementedException();
        }
    }
}