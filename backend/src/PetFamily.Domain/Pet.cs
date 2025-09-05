using System.Runtime.InteropServices.JavaScript;
using CSharpFunctionalExtensions;
using PetFamily.Domain.Species;

namespace PetFamily.Domain;

public class Pet : Entity
{
    private Pet(
        Guid id,
        string name,
        string description,
        Species species,
        string color,
        string medicalInfo,
        string address,
        int weight,
        int height,
        string contactPhone,
        DateTime birthDate,
        bool isSterilized,
        bool isVaccinated,
        PetStaus status,
        IReadOnlyList<DonationDetails> donationDetails)
    {
        Id = id;
        Name = name;
        Description = description;
        //Species
        //Breed
        Color = color;
        MedicalInfo = medicalInfo;
        Address = address;
        Weight = weight;
        Height = height;
        ContactPhone = ContactPhone.Create();
        BirthDate = birthDate;
        IsSterilized = isSterilized;
        IsVaccinated = isVaccinated;
        Status = status;
        DonationDetails = donationDetails;
    }
    
    public Guid Id { get; private set; }
    
    public string Name { get; private set; }
    
    public Species.Species Species { get; private set; }
    
    public string Description { get; private set; }
    
    public Species.Breed Breed { get; private set; }
    
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
    
    public IReadOnlyList<DonationDetails>? DonationDetails { get; private set; }
}