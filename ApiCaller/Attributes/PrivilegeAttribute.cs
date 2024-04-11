using ApiCaller.Extentions;

namespace ApiCaller.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class PrivilegeAttribute : Attribute
    {
        private PrivilegeType Type;
        public double Version;

        public PrivilegeAttribute(PrivilegeType type)
        {
            Type = type;
            Version = 1.0;
        }
        public string GetName() => EnumExtentions.GetDescription(Type);
    }
    public enum PrivilegeType
    {
        None,
        Read,
        Write,
        Remove,
        Update,
        Access,
    }
}
