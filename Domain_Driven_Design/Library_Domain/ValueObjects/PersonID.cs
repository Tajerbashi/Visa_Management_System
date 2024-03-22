namespace Domain_Driven_Design_Solution.Library_Domain.ValueObjects
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
