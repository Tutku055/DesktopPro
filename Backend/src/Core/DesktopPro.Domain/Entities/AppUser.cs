using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopPro.Domain.Entities
{
    public class AppUser: BaseEntitiy
    {
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime? LastLoginDateUtc { get; private set; }
        
        private AppUser() { }

        public AppUser(string username, string passwordHash)
        {
            Username = username;
            PasswordHash = passwordHash;
        }

        public void UpdateLastLoginDate()
        {
            LastLoginDateUtc = DateTime.UtcNow;
        }

        public void UpdatePasswordHash(string newPasswordHash)
        {
            PasswordHash = newPasswordHash;
            UpdatedAt = DateTime.UtcNow;
        }

        public void UpdateUsername(string newUsername)
        {
            Username = newUsername;
            UpdatedAt = DateTime.UtcNow;
        }

    }
}
