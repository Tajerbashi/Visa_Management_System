namespace ApiCaller.Model
{
    public class AccessRole
    {
        public int ID { get; set; }
        public string Privile { get; set; }
        public int? UserID { get; set; }
        public int? RoleID { get; set; }
    }
}
