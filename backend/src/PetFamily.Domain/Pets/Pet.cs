using PetFamily.Domain.Volunteer;

namespace PetFamily.Domain.Pets;

public class Pet : Shared.Entity<PetId>
{
    //ef core
    private Pet(PetId id) : base(id)
    {
    }
    
    private Pet(
        PetId id,
        string name,
        string description,
        Guid speciesId,
        string color,
        string medicalInfo,
        string address,
        int weight,
        int height,
        ContactPhone contactPhone,
        DateTime birthDate,
        bool isSterilized,
        bool isVaccinated,
        PetStaus status,
        DonationDetails donationDetails) : base(id)
    {
        SpeciesId = speciesId;
        Name = name;
        Description = description;
        Color = color;
        MedicalInfo = medicalInfo;
        Address = address;
        Weight = weight;
        Height = height;
        ContactPhone = contactPhone;
        BirthDate = birthDate;
        IsSterilized = isSterilized;
        IsVaccinated = isVaccinated;
        Status = status;
        DonationDetails = donationDetails;
    }
    
    public PetId Id { get; private set; }
    
    public Guid SpeciesId { get; private set; }
    
    public string Name { get; private set; }
    
    public string Description { get; private set; }
    
    public string Color { get; private set; }
    
    public string MedicalInfo { get; private set; }
    
    public string Address { get; private set; }
    
    public int Weight { get; private set; }
    
    public int Height { get; private set; }
    
    public ContactPhone ContactPhone { get; private set; }
    
    public DateTime BirthDate { get; private set; }
    
    public bool IsSterilized  { get; private set; }
    
    public bool IsVaccinated { get; private set; }
    
    public PetStaus Status { get; private set; }
    
    public DonationDetails DonationDetails { get; private set; }
}

public record DonationDetails
{
    public List<DonationDetail> Details { get; private set; }
}