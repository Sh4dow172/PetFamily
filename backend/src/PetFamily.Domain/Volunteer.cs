using CSharpFunctionalExtensions;

namespace PetFamily.Domain;

public class Volunteer : Entity
{
    private Volunteer(
        Guid id,
        string fullName,
        string email,
        string description,
        int experienceYears,
        ContactPhone contactPhone,
        DonationDetails donationDetails,
        List<SocialLink> socialLinks)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        ExperienceYears = experienceYears;
        ContactPhone = contactPhone;
        DonationDetails = donationDetails;
        SocialLinks = socialLinks;
    }
    
    public Guid Id { get; private set; }
    
    public string FullName { get; private set; }
    
    public string Email { get; private set; }
    
    public string Description { get; private set; }
    
    public int ExperienceYears { get; private set; }
    
    public ContactPhone ContactPhone { get; private set; }
    
    public DonationDetails DonationDetails { get; private set; }
    
    public List<Pet>? Pets { get; private set; }
    
    public List<SocialLink>? SocialLinks { get; private set; }

    public int GetAdoptedPetsCount()
    {
        return Pets?.Count(p => p.Status == PetStaus.FoundHome) ?? 0;
    }

    public int GetPetsNeedingHomeCount()
    {
        return Pets?.Count(p => p.Status == PetStaus.LookingForHome) ?? 0;
    }
    
    public int GetPetsInTherapyCount()
    {
        return Pets?.Count(p => p.Status == PetStaus.NeedsHelp) ?? 0;
    }
}