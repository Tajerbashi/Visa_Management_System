namespace Domain_Driven_Design.DomainEntities.ValueObject
{
    public class PersonID
    {
        public string Value { get; set; }
        public PersonID(string value)
        {
            //  Validation 

            Value = value;
        }
    }
}
