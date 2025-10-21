namespace PetFamily.Domain.Species;

public class Breed
{
    //ef core
    public Breed()
    {
    }
    
    public Breed(Guid id, string breedName)
    {
        Id = id;
        BreedName = breedName;
    }
    
    public Guid Id { get; private set; }
    
    public string BreedName { get; private set; }
}