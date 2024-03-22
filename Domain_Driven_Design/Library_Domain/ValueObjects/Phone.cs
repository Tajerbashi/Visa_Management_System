namespace Domain_Driven_Design_Solution.Library_Domain.ValueObjects
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
