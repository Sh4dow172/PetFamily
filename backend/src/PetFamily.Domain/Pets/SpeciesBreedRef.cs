namespace PetFamily.Domain.Pets;

public record SpeciesBreedRef
{
    //ef core
    private SpeciesBreedRef() { }
    
    public SpeciesBreedRef(Guid speciesId, Guid breedId)
    {
        SpeciesId = speciesId;
        BreedId = breedId;
    }
    
    public Guid SpeciesId { get; }
    public Guid BreedId { get; }
}