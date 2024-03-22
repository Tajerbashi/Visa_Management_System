namespace Domain_Driven_Design.Aggregate.ValueObject
{
    public class Email
    {
        public string Value { get; set; }
        public Email(string value)
        {
            //  Validation 

            Value = value;
        }
    }
}
