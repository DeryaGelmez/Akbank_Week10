using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YetgenAkbankJump.Domain.Entities;

namespace YetGenAkbankJump.Persistence.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(60);


            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(60);


            builder.Property(x => x.Country).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(150);


            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.City).HasMaxLength(150);


            builder.Property(x => x.Company).IsRequired();
            builder.Property(x => x.Company).HasMaxLength(250);


            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Age).HasColumnType("smallint)");
            



            builder.Property(x => x.RegistrationFee).IsRequired(false);
            builder.Property(x => x.RegistrationFee).HasColumnType("decimal(19,2)");


            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Gender).HasConversion<int>();


            builder.Property(x => x.IsGraduated).IsRequired();
            builder.Property(x => x.IsGraduated).HasDefaultValueSql("false");



            builder.Property(x => x.CreatedByUserId).IsRequired();
            builder.Property(x => x.CreatedByUserId).HasMaxLength(75);


            builder.Property(x => x.CreatedOn).IsRequired();


            builder.Property(x => x.ModifiedByUserId).IsRequired(false);
            builder.Property(x => x.ModifiedByUserId).HasMaxLength(75);


            builder.Property(x => x.LastModifiedOn).IsRequired(false);


            builder.Property(x => x.DeletedByUserId).IsRequired(false);
            builder.Property(x => x.DeletedByUserId).HasMaxLength(75);


            builder.Property(x => x.DeletedOn).IsRequired(false);


            builder.Property(x => x.IsDeleted).IsRequired();


            builder.ToTable("Students");
        }
    }
}
