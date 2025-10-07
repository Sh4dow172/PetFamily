namespace PetFamily.Domain.Species;

public class Breed
{
    public Breed(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public Guid Id { get; private set; }
    
    public string Name { get; private set; }
}