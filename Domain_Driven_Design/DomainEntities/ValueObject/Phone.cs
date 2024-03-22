namespace Domain_Driven_Design.DomainEntities.ValueObject
{
    public class Phone
    {
        public string Value { get; set; }
        public Phone(string value)
        {
            //  Validation 

            Value = value;
        }
    }
}
