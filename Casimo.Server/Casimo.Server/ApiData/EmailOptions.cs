namespace Casimo.Server.ApiData;

public class EmailOptions
{
    public string LoginUrl { get; set; } = string.Empty;

    public bool SendEmails { get; set; }
    public string FromAddress { get; set; } = string.Empty;
}