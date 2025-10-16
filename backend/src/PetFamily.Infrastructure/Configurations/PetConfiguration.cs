using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain.Pets;
using PetFamily.Domain.Shared;

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

        // builder.Property(p => p.ContactPhone)
        //     .HasMaxLength(Constants.MAX_PHONE_LENGTH)
        //     .HasConversion(
        //         phone => phone.PhoneNumber,
        //         value => ContactPhone.Create(value));
        
        builder.Property(p => p.BirthDate)
            .IsRequired();
        
        builder.Property(p => p.IsSterilized)
            .IsRequired();
        
        builder.Property(p => p.IsVaccinated)
            .IsRequired();
        
        builder.Property(p => p.Status)
            .IsRequired();

        builder.OwnsOne(p => p.DonationDetails, dd =>
        {
            dd.ToJson();
            
            dd.OwnsMany(d => d.Details, db =>
            {
                db.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);

                db.Property(x => x.Description)
                    .IsRequired()
                    .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);
            });
        });
    }
}