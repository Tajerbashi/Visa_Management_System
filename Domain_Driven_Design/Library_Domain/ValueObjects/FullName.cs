namespace Domain_Driven_Design_Solution.Library_Domain.ValueObjects
{
    public class FullName
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public FullName(string name, string family)
        {
            //  Validation
            Name = name;
            Family = family;
        }
    }
}
