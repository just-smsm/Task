using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90.Model
{
    internal class Task_Configuration : IEntityTypeConfiguration<Tasks>
    {
        public void Configure(EntityTypeBuilder<Tasks> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Tittle).IsRequired();
            builder.Property(e => e.Date).IsRequired();
            builder.ToTable("NewTask");
            builder.Property(e => e.Date).HasColumnName("DeadLine");
        }
    }
}
