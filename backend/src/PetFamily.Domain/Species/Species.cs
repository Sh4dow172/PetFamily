namespace PetFamily.Domain.Species;

public class Species
{
    //ef core
    private Species()
    {
    }
    
    public Species(Guid id, string speciesName, List<Breed> breeds)
    {
        Id = id;
        SpeciesName = speciesName;
        Breeds = breeds;
    }
    
    public Guid Id { get; private set; }
    
    public string SpeciesName { get; private set; }

    public List<Breed> Breeds { get; private set; } = [];
}