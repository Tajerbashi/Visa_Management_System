namespace Blazor_Domain_Library_Test.Security.UserTest
{
    public static class ClassPassData
    {
        public static List<object[]> Data()
        {
            var List = new List<object[]>();
            List.Add(new object[] {"",false });
            List.Add(new object[] {"name",false });
            List.Add(new object[] {"Tajerbashi", true });
            return List.ToList();
        }
    }
}
