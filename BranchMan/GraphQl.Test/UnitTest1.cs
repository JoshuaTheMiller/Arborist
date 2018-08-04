using GraphQl.QueryConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphQl.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var queryName = "TestQuery";
            var query = Query.Empty(queryName);            
            var nameField = Field.Simple("name");

            query.AddField(nameField);

            var converter = new OperationConverter();

            var operationAsString = converter.ConvertToString(query);

            "".ToString();
        }
    }
}
