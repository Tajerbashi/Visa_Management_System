namespace Domain_Driven_Design.Aggregate.ValueObject
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
