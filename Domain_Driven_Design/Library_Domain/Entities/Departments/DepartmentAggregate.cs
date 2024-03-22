using Domain_Driven_Design_Solution.Library_Domain.Entities.Users;
using Domain_Driven_Design_Solution.Library_Domain.Interfaces;

namespace Domain_Driven_Design_Solution.Library_Domain.Entities.Departments
{
    public partial class Department : IAggregateRoot
    {
        public Department()
        {
            Users = new HashSet<User>();
        }

        public Department(string name
            , string description) : this()
        {
            this.Update(name, description);
        }

        public void Update(string name
            , string description)
        {
            Name = name;
            Description = description;
        }
    }
}
