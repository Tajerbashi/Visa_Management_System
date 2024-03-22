namespace Domain_Driven_Design.Aggregate.ValueObject
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
