using Domain_Driven_Design_Solution.Library_Domain.ValueObjects;

namespace Domain_Driven_Design_Solution.Library_Domain.Entities
{
    public class Person
    {
        public Person(
            PersonID id,
            FullName fullName,
            Email email,
            Phone phone
            )
        {
            ID = id;
            FullName = fullName;
            Email = email;
            Phone = phone;
        }
        public PersonID ID { get; set; }
        public FullName FullName { get; set; }
        public Email Email { get; set; }
        public Phone Phone { get; set; }
    }
}
