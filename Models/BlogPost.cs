namespace whatTechAPI.Models;

public record BlogPost
{
    public long Id {get; set;}
    public string? Title {get; init;}
    public string? Content {get; init;}
    public string? Author {get; init;}
    public DateTime PublishDate {get; init;} 

    
}