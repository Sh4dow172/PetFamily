namespace PetFamily.Domain.Species;

public class Species
{
    public Species(Guid id, string breedName, List<Breed> breeds)
    {
        Id = id;
        BreedName = breedName;
        Breeds = breeds;
    }
    
    public Guid Id { get; private set; }
    
    public string BreedName { get; private set; }
    
    public List<Breed> Breeds { get; private set; }
}