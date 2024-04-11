namespace ApiCaller.Model
{
    public static class Database
    {
        public static List<User> Users()
        {
            var list = new List<User>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(new User
                {
                    ID = i,
                    FullName = $"User {i}",
                    Username = $"Username{i}",
                });
            }
            return list.ToList();
        }
        public static List<Role> Roles()
        {
            var list = new List<Role>();
            list.Add(new Role { ID = 1, RoleName = "Admin" });
            list.Add(new Role { ID = 2, RoleName = "User" });
            list.Add(new Role { ID = 3, RoleName = "VIP" });
            return list.ToList();
        }
        public static List<UserRole> UserRoles()
        {
            var list = new List<UserRole>();
            list.Add(new UserRole { ID = 1, UserID = 1, RoleID = 1 });
            list.Add(new UserRole { ID = 1, UserID = 1, RoleID = 2 });
            list.Add(new UserRole { ID = 1, UserID = 2, RoleID = 1 });
            list.Add(new UserRole { ID = 1, UserID = 2, RoleID = 3 });
            list.Add(new UserRole { ID = 1, UserID = 3, RoleID = 2 });
            list.Add(new UserRole { ID = 1, UserID = 4, RoleID = 1 });
            return list.ToList();
        }
        public static List<AccessRole> AccessRoles()
        {
            var list = new List<AccessRole>();
            list.Add(new AccessRole
            {
                ID = 1,
                RoleID = 1,
                UserID = null,
                Privile = "UserService.Read"
            });
            list.Add(new AccessRole
            {
                ID = 2,
                RoleID = 1,
                UserID = null,
                Privile = "UserService.Write"
            });
            list.Add(new AccessRole
            {
                ID = 3,
                RoleID = 1,
                UserID = null,
                Privile = "UserService.Create"
            });
            list.Add(new AccessRole
            {
                ID = 4,
                RoleID = 1,
                UserID = null,
                Privile = "UserService.Update"
            });

            list.Add(new AccessRole
            {
                ID = 5,
                RoleID = 2,
                UserID = null,
                Privile = "UserService.Read"
            });
            list.Add(new AccessRole
            {
                ID = 6,
                RoleID = 2,
                UserID = null,
                Privile = "UserService.Write"
            });
            list.Add(new AccessRole
            {
                ID = 7,
                RoleID = 3,
                UserID = null,
                Privile = "UserService.Update"
            });

            list.Add(new AccessRole
            {
                ID = 8,
                RoleID = 3,
                UserID = null,
                Privile = "UserService.Delete"
            });
            return list.ToList();
        }
   
    }
}
