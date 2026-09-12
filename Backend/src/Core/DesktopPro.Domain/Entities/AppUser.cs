using System;

namespace DesktopPro.Domain.Entities;

/// <summary>
/// Represents an application user account.
/// </summary>
public class AppUser : BaseEntity
{
    /// <summary>
    /// Unique username. Max length configured in persistence: 50.
    /// </summary>
    public string Username { get; private set; } = string.Empty;

    /// <summary>
    /// Password hash representation. Max length configured in persistence: 256.
    /// </summary>
    public string PasswordHash { get; private set; } = string.Empty;

    public DateTime? LastLoginDateUtc { get; private set; }

    protected AppUser() { }

    public AppUser(string username, string passwordHash)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(username);
        ArgumentException.ThrowIfNullOrWhiteSpace(passwordHash);

        Username = username;
        PasswordHash = passwordHash;
    }

    public void UpdateLastLoginDate()
    {
        LastLoginDateUtc = DateTime.UtcNow;
    }

    public void UpdatePasswordHash(string newPasswordHash)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(newPasswordHash);
        PasswordHash = newPasswordHash;
        UpdatedAt = DateTime.UtcNow;
    }

    public void UpdateUsername(string newUsername)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(newUsername);
        Username = newUsername;
        UpdatedAt = DateTime.UtcNow;
    }
}
