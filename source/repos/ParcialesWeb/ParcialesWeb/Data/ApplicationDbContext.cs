using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelsK;

namespace ParcialesWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EstudianteK>().HasAlternateKey(e => e.Email);
            builder.Entity<CursoK>().HasAlternateKey(c => new { c.MateriaKId, c.AñoSem, c.Grupo });
            builder.Entity<ParcialK>().HasAlternateKey(p => new { p.EstudianteKId, p.CursoKId, p.Número });
        }
        public DbSet<ModelsK.CursoK> CursoK { get; set; }
        public DbSet<ModelsK.EstudianteK> EstudianteK { get; set; }
        public DbSet<ModelsK.MateriaK> MateriaK { get; set; }
        public DbSet<ModelsK.ParcialK> ParcialK { get; set; }
    }
}
