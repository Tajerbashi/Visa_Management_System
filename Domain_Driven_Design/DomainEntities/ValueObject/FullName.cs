namespace Domain_Driven_Design.DomainEntities.ValueObject
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
