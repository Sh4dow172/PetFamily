using CSharpFunctionalExtensions;

namespace PetFamily.Domain;

public record DonationDetails
{
    private DonationDetails(string name, string description)
    {
        Name = name;
        Description = description;
    }
    
    public string Name { get; }
    public string Description { get; }

    public static Result<DonationDetails> Create(string name, string description)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            return Result.Failure<DonationDetails>("Name and network name cannot be empty.");
        
        return new DonationDetails(name, description);
    }
}