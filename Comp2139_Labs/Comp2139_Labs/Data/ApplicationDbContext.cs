using System;
using Microsoft.EntityFrameworkCore;
namespace Comp2139_Labs.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

		public DbSet<Project> Projects { get; set; }
		
	}
}


