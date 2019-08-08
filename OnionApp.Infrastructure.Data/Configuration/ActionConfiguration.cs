using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Infrastructure.Data.Configuration
{
    public class ActionConfiguration : IEntityTypeConfiguration<ActionExecuting>
    {
        public void Configure(EntityTypeBuilder<ActionExecuting> builder)
        {
            builder.HasKey(_ => _.Id);
        }
    }
}
