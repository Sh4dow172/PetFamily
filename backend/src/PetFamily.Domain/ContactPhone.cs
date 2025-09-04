using CSharpFunctionalExtensions;

namespace PetFamily.Domain;

public record ContactPhone
{
    private ContactPhone(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }
    
    public string PhoneNumber { get; }

    public static Result<ContactPhone> Create(ContactPhone phoneNumber)
    {
        if (phoneNumber == null)
            return Result.Failure<ContactPhone>("Phone number cannot be null.");
        
        return new ContactPhone(phoneNumber);
    }
}