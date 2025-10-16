using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetFamily.Domain;
using PetFamily.Domain.Shared;
using PetFamily.Domain.Volunteer;

namespace PetFamily.Infrastructure.Configurations;

public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
{
    public void Configure(EntityTypeBuilder<Volunteer> builder)
    {
        builder.ToTable("Volunteers");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasConversion(
                id => id.Value,
                value => VolunteerId.Create(value));

        builder.Property(v => v.FullName)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
        
        builder.Property(v => v.Email)
            .IsRequired()
            .HasMaxLength(Constants.MAX_LOW_TEXT_LENGTH);
        
        builder.Property(v => v.Description)
            .IsRequired()
            .HasMaxLength(Constants.MAX_HIGH_TEXT_LENGTH);

        // builder.Property(v => v.ContactPhone)
        //     .IsRequired()
        //     .HasConversion(pn => pn.PhoneNumber,
        //         value => ContactPhone.Create(value));
        
        builder.OwnsOne(v => v.DonationDetails, dd =>
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

        builder.Property(v => v.Pets)
            .IsRequired(false);

        builder.OwnsOne(v => v.SocialLinks, sl =>
        {
            sl.ToJson();

            sl.OwnsMany(l => l.)
        });
    }
}