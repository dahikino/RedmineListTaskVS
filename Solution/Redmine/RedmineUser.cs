using System;

namespace Redmine
{
    public class RedmineUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastLoginTime { get; set; }
    }
}
