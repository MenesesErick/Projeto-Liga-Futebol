namespace Liga_Tabajara.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComissaoTecnicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cargo = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeId, cascadeDelete: true)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cidade = c.String(nullable: false),
                        Estado = c.String(nullable: false),
                        AnoFundacao = c.Int(nullable: false),
                        Estadio = c.String(),
                        CapacidadeEstadio = c.Int(nullable: false),
                        CorUniformePrincipal = c.String(),
                        CorUniformeSecundario = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Nacionalidade = c.String(),
                        Posicao = c.Int(nullable: false),
                        NumeroCamisa = c.Int(nullable: false),
                        Altura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PePreferido = c.Int(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeId, cascadeDelete: true)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Gols",
                c => new
                    {
                        GolId = c.Int(nullable: false, identity: true),
                        JogadorId = c.Int(nullable: false),
                        PartidaId = c.Int(nullable: false),
                        Minuto = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GolId)
                .ForeignKey("dbo.Jogadors", t => t.JogadorId, cascadeDelete: true)
                .ForeignKey("dbo.Partidas", t => t.PartidaId, cascadeDelete: true)
                .Index(t => t.JogadorId)
                .Index(t => t.PartidaId);
            
            CreateTable(
                "dbo.Partidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        TimeCasaId = c.Int(nullable: false),
                        TimeVisitanteId = c.Int(nullable: false),
                        GolsCasa = c.Int(),
                        GolsVisitante = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeCasaId)
                .ForeignKey("dbo.Times", t => t.TimeVisitanteId)
                .Index(t => t.TimeCasaId)
                .Index(t => t.TimeVisitanteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Partidas", "TimeVisitanteId", "dbo.Times");
            DropForeignKey("dbo.Partidas", "TimeCasaId", "dbo.Times");
            DropForeignKey("dbo.Gols", "PartidaId", "dbo.Partidas");
            DropForeignKey("dbo.Gols", "JogadorId", "dbo.Jogadors");
            DropForeignKey("dbo.Jogadors", "TimeId", "dbo.Times");
            DropForeignKey("dbo.ComissaoTecnicas", "TimeId", "dbo.Times");
            DropIndex("dbo.Partidas", new[] { "TimeVisitanteId" });
            DropIndex("dbo.Partidas", new[] { "TimeCasaId" });
            DropIndex("dbo.Gols", new[] { "PartidaId" });
            DropIndex("dbo.Gols", new[] { "JogadorId" });
            DropIndex("dbo.Jogadors", new[] { "TimeId" });
            DropIndex("dbo.ComissaoTecnicas", new[] { "TimeId" });
            DropTable("dbo.Partidas");
            DropTable("dbo.Gols");
            DropTable("dbo.Jogadors");
            DropTable("dbo.Times");
            DropTable("dbo.ComissaoTecnicas");
        }
    }
}
