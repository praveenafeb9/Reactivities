

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
				new Value1 { Id=4, Name="Val 101"},
				new Value1 { Id = 5, Name = "Val 102" },
				new Value1 { Id = 6, Name = "Val 103" }
				);
		}
        
     }
}