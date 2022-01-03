namespace ProjectManager.Models.Database;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortDesc { get; set; }
    public string LongDesc { get; set; }
    public User Creator { get; set; }
    public List<string> ScreenshotLinks { get; set; }
    public string AvatarLink { get; set; }
    public string LinkForDownload { get; set; }
    public Category Category { get; set; }
    public TargetOS TargetOS { get; set; }
}