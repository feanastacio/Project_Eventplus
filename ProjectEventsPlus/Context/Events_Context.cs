using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ProjectEventsPlus.Domain;

namespace ProjectEventsPlus.Context
{
    public class Events_Context : DbContext
    {
        Events_Context() { }
        public Events_Context(DbContextOptions<Events_Context> options) : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
        public DbSet<Presenca> Presenca { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-S3CGL03\\SQLEXPRESS; Database=ProjectEvents; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true; ");
            }

        }
    }
}
