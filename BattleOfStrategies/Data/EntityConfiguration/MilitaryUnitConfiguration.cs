using BattleOfStrategies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml;

namespace BattleOfStrategies.Data.EntityConfiguration
{
    public class MilitaryUnitConfiguration : IEntityTypeConfiguration<MilitaryUnit>
    {
        public void Configure(EntityTypeBuilder<MilitaryUnit> builder)
        {
            builder.HasKey(m => m.Id);

            builder.HasData(new MilitaryUnit { Id = 1, /* other properties */ });

            builder.Property(p => p.Id)
            .UseIdentityColumn();

            builder.Property(m => m.Name)
                .IsRequired()
                .HasDefaultValue("Infantryman");
            builder.Property(m => m.Range)
                .IsRequired()
                .HasDefaultValue(1)
                .HasAnnotation("Range", new[] { 1, 10 });
            builder.Property(m => m.Level)
                .IsRequired()
                .HasDefaultValue(1)
                .HasAnnotation("Level", new[] { 1, 5 });
            builder.Property(m => m.Damage)
                .IsRequired()
                .HasDefaultValue(.2);
            //.HasPrecision(3);
            //.HasAnnotation("Damage", new[] { 0.1, 1.0 });
            builder.Property(m => m.HP)
                .IsRequired()
                .HasDefaultValue(1.0);
            //.HasPrecision(3);
            //.HasAnnotation("HP", new[] { 1.0, 3.0 });
            builder.Property(m => m.Aim)
                .IsRequired()
                .HasDefaultValue(0.1);
            //.HasPrecision(3);
            //.HasAnnotation("Aim", new[] { 0.1, 1.0 });
            builder.Property(m => m.AffectedArea)
                .IsRequired()
                .HasDefaultValue(1)
                .HasAnnotation("AffectedArea", new[] { 1, 5 });
        }
    }
}
