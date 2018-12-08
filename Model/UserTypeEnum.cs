using System.Collections.Generic;

namespace Model
{
    public static class UserTypeEnum
    {
        public enum UserType
        {
            Admin,
            Manager,
            Receptionist
        }

        public static Dictionary<UserType, string> UserTypeToStringDictionary = new Dictionary<UserType, string>
        {
            [UserType.Admin] = "Administrator",
            [UserType.Manager] = "Manager",
            [UserType.Receptionist] = "Receptionist"
        };
    }
}
