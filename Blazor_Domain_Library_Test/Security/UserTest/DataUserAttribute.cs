using System.Reflection;
using Xunit.Sdk;

namespace Blazor_Domain_Library_Test.Security.UserTest
{
    public class DataUserAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var List = new List<object[]>();
            List.Add(new object[] { "", false });
            List.Add(new object[] { "name", false });
            List.Add(new object[] { "Tajerbashi", true });
            return List.ToList();
        }
    }
}
