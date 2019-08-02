using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
namespace EFCore.Infrastructure.Data.Configuration
{
    class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {

            builder.HasKey(_ => _.Id);
            builder.HasOne(p => p.Student).WithMany(t => t.Lessons).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
