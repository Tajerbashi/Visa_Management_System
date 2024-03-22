using Domain_Driven_Design_Solution.Library_Domain.Base;
using Domain_Driven_Design_Solution.Library_Domain.Entities.Users;

namespace Domain_Driven_Design_Solution.Library_Domain.Entities.Departments
{
    public partial class Department : BaseEntity<short>
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }

        public virtual ICollection<User> Users { get; internal set; }
    }
}
