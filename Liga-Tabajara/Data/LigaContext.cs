using System.Data.Entity;

namespace Liga_Tabajara.Data
{
    public class LigaContext : DbContext
    {
        // Construtor que passa o nome da connection string
        public LigaContext() : base("LigaContext") { }

        // DbSets para cada entidade
        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<ComissaoTecnica> ComissaoTecnica { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<Gol> Gols { get; set; }

        // (Opcional) Configurações adicionais do modelo
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração para evitar conflitos em deleção em cascata entre Partida e Time
            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeCasa)
                .WithMany()
                .HasForeignKey(p => p.TimeCasaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeVisitante)
                .WithMany()
                .HasForeignKey(p => p.TimeVisitanteId)
                .WillCascadeOnDelete(false);
        }
    }
}