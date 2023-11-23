using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Drawing;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    // allowed hard coding (building something that can last: overthink abit)
                    Id = 1,
                    Name = "Black",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Colour
                {
                    Id = 2,
                    Name = "Blue",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
             );
        }
    }
}
