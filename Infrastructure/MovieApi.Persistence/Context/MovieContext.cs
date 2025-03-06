using Microsoft.EntityFrameworkCore;
using MovieApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MovieApi.Persistence.Context
{
    public class MovieContext :DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=GE-ABALLI15\\MSSQLSERVER2022;database=MovieApiDb;user id=sa;password=Btnsft1958;TrustServerCertificate=True;");
		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Cast> Casts { get; set; }
	
	}
}
