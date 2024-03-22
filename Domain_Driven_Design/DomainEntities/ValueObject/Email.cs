namespace Domain_Driven_Design.DomainEntities.ValueObject
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
