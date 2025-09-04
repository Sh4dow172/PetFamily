using System.Runtime.InteropServices.JavaScript;
using CSharpFunctionalExtensions;
using PetFamily.Domain.Species;

namespace PetFamily.Domain;

public class Pet : Entity
{
    public Pet(
        Guid id,
        string name, 
        string email
        
        )
    {
        
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
    
    public List<DonationDetails>? DonationDetails { get; private set; }
}