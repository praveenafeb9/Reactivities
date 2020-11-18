

using System;
using Microsoft.EntityFrameworkCore;
using Domain;


namespace Persistence
{
    public class  SampleDbContext : DbContext
    {   
        public SampleDbContext(DbContextOptions options) : base(options)
        {
            
        } 

        public DbSet<Value1> Values{get; set;}

		protected override void OnModelCreating(ModelBuilder builder) 
		{
			builder.Entity<Value1>().HasData(
				new Value1 { Id=1, Name="Name 101"},
				new Value1 { Id = 2, Name = "Name 102" },
				new Value1 { Id = 3, Name = "Name 103" }
				);
		}
        
     }
}