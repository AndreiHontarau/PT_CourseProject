using System.Collections.Generic;

namespace Model
{
    public class UserRecord : Record
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public UserRole Role { get; private set; }

        public UserRecord(string name, string password, UserRole role)
        {
            Name = name;
            Password = password;
            Role = role;
        }

        public enum UserRole
        {
            Admin,
            Manager,
            Receptionist
        }

        /// <summary>
        /// Gets string representation of User's role
        /// </summary>
        /// <returns>String representation of User's role</returns>
        public override string ToString()
        {
            return UserRoleToStringDictionary[Role];
        }

        private static Dictionary<UserRole, string> UserRoleToStringDictionary = new Dictionary<UserRole, string>
        {
            [UserRole.Admin] = "Administrator",
            [UserRole.Manager] = "Manager",
            [UserRole.Receptionist] = "Receptionist"
        };
    }
}
