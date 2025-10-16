using CSharpFunctionalExtensions;

namespace PetFamily.Domain;

public record DonationDetail
{
    private DonationDetail(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public string Name { get; }
    public string Description { get; }

    public static Result<DonationDetail> Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            return Result.Failure<DonationDetail>("Name and network name cannot be empty.");
        
        return new DonationDetail(name, description);
    }
}