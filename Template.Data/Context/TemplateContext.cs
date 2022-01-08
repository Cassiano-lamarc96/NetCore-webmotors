using Microsoft.EntityFrameworkCore;
using Template.Data.Mappings;
using Template.Domain.Entities;

namespace Template.Data.Context
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> option)
            : base(option) { }

        #region "DbSets"

        public DbSet<Anuncio> Anuncios { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnuncioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
