namespace Domain_Driven_Design_Solution.Library_Domain.ValueObjects
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
