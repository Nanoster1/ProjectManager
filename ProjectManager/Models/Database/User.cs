using Microsoft.AspNetCore.Identity;

namespace ProjectManager.Models.Database;

public class User: IdentityUser
{
    public string AvatarLink { get; set; }
    public string LongDesc { get; set; }
    public string ShortDesc { get; set; }
    public bool IsOrganisation { get; set; }
    public List<Project> Projects { get; set; }
}