using Domain_Driven_Design.DomainEntities.ValueObject;

namespace Domain_Driven_Design.DomainEntities
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
