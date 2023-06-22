using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using Vtitbid.ISP20.Strizhak.Ex.Entities;

namespace Vtitbid.ISP20.Strizhak.Ex.Data
{
	public class AppDbContext : DbContext
	{
		private const string ConnectingString = @"Server=.;Database=ExDb;Trusted_Connection=true";
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(ConnectingString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
		}

        public DbSet<Price> Prices { get; set; }

    }
}
