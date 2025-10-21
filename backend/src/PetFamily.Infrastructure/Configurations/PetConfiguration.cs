using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain;
using PetFamily.Domain.Pets;
using PetFamily.Domain.Shared;
using PetFamily.Domain.Volunteer;

namespace PetFamily.Infrastructure.Configurations;

public class PetConfiguration : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.ToTable("Pets");
        
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Id)
            .HasConversion(
                id => id.Value,
                value => PetId.Create(value));
        
        builder.Property(p => p.VolunteerId)
            .HasConversion(
                id => id.Value,
                value => VolunteerId.Create(value));

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);
        
        builder.Property(p => p.Color)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
        
        builder.Property(p => p.MedicalInfo)
            .IsRequired()
            .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

        builder.Property(p => p.Weight)
            .IsRequired();
        
        builder.Property(p => p.Height)
            .IsRequired();

        builder.Property(p => p.ContactPhone)
            .HasMaxLength(Constants.MAX_PHONE_LENGTH)
            .HasConversion(
                phone => phone.PhoneNumber,
                value => ContactPhone.Create(value).Value);
        
        builder.Property(p => p.BirthDate)
            .IsRequired();
        
        builder.Property(p => p.IsSterilized)
            .IsRequired();
        
        builder.Property(p => p.IsVaccinated)
            .IsRequired();
        
        builder.Property(p => p.Status)
            .IsRequired();

        builder.OwnsOne(p => p.SpeciesBreedRef, sb =>
        {
            sb.ToJson();
        });

        builder.OwnsMany(p => p.DonationDetails, dd =>
        {
            dd.ToJson();
            
            dd.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
            
            dd.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);
        });
    }
}