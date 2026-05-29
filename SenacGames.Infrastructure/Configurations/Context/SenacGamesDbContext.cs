using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SenacGames.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infrastructure.Configurations.Context
{
    public class SenacGamesDbContext : IdentityDbContext
    {
        public SenacGamesDbContext(DbContextOptions<SenacGamesDbContext> options)
            : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
        /// <summary>
        /// DbSet que representa a tabela de Games no banco de Dados.
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        };
    };
}
