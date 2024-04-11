namespace ApiCaller.Model
{
    public class UserDTO
    {
        public UserDTO(string role)
        {
            Roles = new List<Role>
            {
                new Role{ID=1,RoleName=role},
            };
        }
        public int Id { get; set; }
        public string FullName { get; set; }

        public List<Role> Roles { get; set; }
    }
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
    }
}
