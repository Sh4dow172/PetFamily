using CSharpFunctionalExtensions;

namespace PetFamily.Domain;

public record SocialLink
{
    private SocialLink(string networkName, string networkUrl)
    {
        NetworkName = networkName;
        NetworkUrl = networkUrl;
    }
    
    public string NetworkName { get; }
    
    public string NetworkUrl { get; }

    public static Result<SocialLink> Create(string networkName, string networkUrl)
    {
        if (string.IsNullOrWhiteSpace(networkName) || string.IsNullOrWhiteSpace(networkUrl))
        {
            return Result.Failure<SocialLink>("Network name and network url cannot be empty.");
        }
        
        return new SocialLink(networkName, networkUrl);
    }
}