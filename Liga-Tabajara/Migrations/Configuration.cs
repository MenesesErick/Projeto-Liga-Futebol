namespace Liga_Tabajara.Migrations
{

    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Liga_Tabajara.Data.LigaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Liga_Tabajara.Data.LigaContext context)
        {
            var times = new List<Time>
            {
                new Time {
                    Nome = "Flamengo 2019",
                    Cidade = "Rio de Janeiro",
                    Estado = "RJ",
                    AnoFundacao = 1895,
                    Estadio = "Maracanã",
                    CapacidadeEstadio = 78838,
                    CorUniformePrincipal = "Vermelho e Preto",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Real Madrid 2017",
                    Cidade = "Madrid",
                    Estado = "Espanha",
                    AnoFundacao = 1902,
                    Estadio = "Santiago Bernabéu",
                    CapacidadeEstadio = 81044,
                    CorUniformePrincipal = "Branco",
                    CorUniformeSecundario = "Preto",
                    Status = true
                },
                new Time {
                    Nome = "Barcelona 2012",
                    Cidade = "Barcelona",
                    Estado = "Espanha",
                    AnoFundacao = 1899,
                    Estadio = "Camp Nou",
                    CapacidadeEstadio = 99354,
                    CorUniformePrincipal = "Azul e Grená",
                    CorUniformeSecundario = "Dourado",
                    Status = true
                },
                new Time {
                    Nome = "Vasco 2002",
                    Cidade = "Rio de Janeiro",
                    Estado = "RJ",
                    AnoFundacao = 1898,
                    Estadio = "São Januário",
                    CapacidadeEstadio = 21880,
                    CorUniformePrincipal = "Preto e Branco",
                    CorUniformeSecundario = "Vermelho",
                    Status = true
                },
                new Time {
                    Nome = "Liverpool 2019",
                    Cidade = "Liverpool",
                    Estado = "Inglaterra",
                    AnoFundacao = 1892,
                    Estadio = "Anfield",
                    CapacidadeEstadio = 53394,
                    CorUniformePrincipal = "Vermelho",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Bayern Munich 2020",
                    Cidade = "Munique",
                    Estado = "Alemanha",
                    AnoFundacao = 1900,
                    Estadio = "Allianz Arena",
                    CapacidadeEstadio = 75000,
                    CorUniformePrincipal = "Vermelho e Branco",
                    CorUniformeSecundario = "Azul",
                    Status = true
                },
                new Time {
                    Nome = "Milan 1989",
                    Cidade = "Milão",
                    Estado = "Itália",
                    AnoFundacao = 1899,
                    Estadio = "San Siro",
                    CapacidadeEstadio = 80018,
                    CorUniformePrincipal = "Vermelho e Preto",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Manchester United 1999",
                    Cidade = "Manchester",
                    Estado = "Inglaterra",
                    AnoFundacao = 1878,
                    Estadio = "Old Trafford",
                    CapacidadeEstadio = 74140,
                    CorUniformePrincipal = "Vermelho",
                    CorUniformeSecundario = "Preto",
                    Status = true
                },
                new Time {
                    Nome = "Santos 1962",
                    Cidade = "Santos",
                    Estado = "SP",
                    AnoFundacao = 1912,
                    Estadio = "Vila Belmiro",
                    CapacidadeEstadio = 16068,
                    CorUniformePrincipal = "Branco",
                    CorUniformeSecundario = "Preto",
                    Status = true
                },
                new Time {
                    Nome = "Ajax 1995",
                    Cidade = "Amsterdã",
                    Estado = "Holanda",
                    AnoFundacao = 1900,
                    Estadio = "Johan Cruyff Arena",
                    CapacidadeEstadio = 55865,
                    CorUniformePrincipal = "Branco e Vermelho",
                    CorUniformeSecundario = "Preto",
                    Status = true
                },
                new Time {
                    Nome = "Corinthians 2012",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    AnoFundacao = 1910,
                    Estadio = "Arena Corinthians",
                    CapacidadeEstadio = 49205,
                    CorUniformePrincipal = "Branco",
                    CorUniformeSecundario = "Preto",
                    Status = true
                },
                new Time {
                    Nome = "São Paulo 2005",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    AnoFundacao = 1930,
                    Estadio = "Morumbi",
                    CapacidadeEstadio = 66795,
                    CorUniformePrincipal = "Vermelho, Preto e Branco",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Chelsea 2012",
                    Cidade = "Londres",
                    Estado = "Inglaterra",
                    AnoFundacao = 1905,
                    Estadio = "Stamford Bridge",
                    CapacidadeEstadio = 40834,
                    CorUniformePrincipal = "Azul",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Inter Milan 2010",
                    Cidade = "Milão",
                    Estado = "Itália",
                    AnoFundacao = 1908,
                    Estadio = "San Siro",
                    CapacidadeEstadio = 80018,
                    CorUniformePrincipal = "Azul e Preto",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Boca Juniors 2003",
                    Cidade = "Buenos Aires",
                    Estado = "Argentina",
                    AnoFundacao = 1905,
                    Estadio = "La Bombonera",
                    CapacidadeEstadio = 54000,
                    CorUniformePrincipal = "Azul e Ouro",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Juventus 1985",
                    Cidade = "Turim",
                    Estado = "Itália",
                    AnoFundacao = 1897,
                    Estadio = "Allianz Stadium",
                    CapacidadeEstadio = 41507,
                    CorUniformePrincipal = "Preto e Branco",
                    CorUniformeSecundario = "Rosa",
                    Status = true
                },
                new Time {
                    Nome = "Palmeiras 1999",
                    Cidade = "São Paulo",
                    Estado = "SP",
                    AnoFundacao = 1914,
                    Estadio = "Allianz Parque",
                    CapacidadeEstadio = 43713,
                    CorUniformePrincipal = "Verde",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Paris Saint-Germain 2020",
                    Cidade = "Paris",
                    Estado = "França",
                    AnoFundacao = 1970,
                    Estadio = "Parc des Princes",
                    CapacidadeEstadio = 47929,
                    CorUniformePrincipal = "Azul, Vermelho e Branco",
                    CorUniformeSecundario = "Branco",
                    Status = true
                },
                new Time {
                    Nome = "Atlético Madrid 2014",
                    Cidade = "Madrid",
                    Estado = "Espanha",
                    AnoFundacao = 1903,
                    Estadio = "Wanda Metropolitano",
                    CapacidadeEstadio = 68456,
                    CorUniformePrincipal = "Vermelho e Branco",
                    CorUniformeSecundario = "Azul",
                    Status = true
                },
                new Time {
                    Nome = "Benfica 1962",
                    Cidade = "Lisboa",
                    Estado = "Portugal",
                    AnoFundacao = 1904,
                    Estadio = "Estádio da Luz",
                    CapacidadeEstadio = 64642,
                    CorUniformePrincipal = "Vermelho",
                    CorUniformeSecundario = "Branco",
                    Status = true
                }
            };

            times.ForEach(t => context.Times.AddOrUpdate(p => p.Nome, t));
            context.SaveChanges();

            var flamengo = context.Times.FirstOrDefault(t => t.Nome == "Flamengo 2019");
            if (flamengo != null)
            {
                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Jorge Jesus", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1954, 7, 24), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "João de Deus", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1961, 3, 31), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Mário Monteiro", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1974, 1, 5), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Rodrigo Lasmar", Cargo = Cargo.Fisiologista, DataNascimento = new DateTime(1974, 7, 17), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Alexandre Schneider", Cargo = Cargo.TreinadorGoleiros, DataNascimento = new DateTime(1971, 8, 22), TimeId = flamengo.Id },
                    new ComissaoTecnica { Nome = "Rogério Corrêa", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1975, 9, 10), TimeId = flamengo.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Diego Alves",           DataNascimento = new DateTime(1985, 6, 24), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumeroCamisa = 1,  Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Gabriel Batista",       DataNascimento = new DateTime(1997, 7, 1),  Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumeroCamisa = 22, Altura = 1.90m, Peso = 82m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "César",                 DataNascimento = new DateTime(1991, 11, 9), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumeroCamisa = 37, Altura = 1.93m, Peso = 83m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Hugo Souza",            DataNascimento = new DateTime(2001, 3, 31), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,     NumeroCamisa = 45, Altura = 1.96m, Peso = 82m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },

                    // Defensores
                    new Jogador { Nome = "Rodinei",               DataNascimento = new DateTime(1992, 2, 29), Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumeroCamisa = 2,  Altura = 1.75m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Rodrigo Caio",          DataNascimento = new DateTime(1993, 8, 17), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumeroCamisa = 3,  Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Pablo Marí",            DataNascimento = new DateTime(1993, 8, 1),  Nacionalidade = "Espanha", Posicao = Posicao.Zagueiro,   NumeroCamisa = 4,  Altura = 1.89m, Peso = 83m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Renê",                  DataNascimento = new DateTime(1992, 2, 6),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumeroCamisa = 6,  Altura = 1.69m, Peso = 68m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Rafinha",               DataNascimento = new DateTime(1985, 9, 7),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumeroCamisa = 13, Altura = 1.70m, Peso = 64m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Filipe Luís",           DataNascimento = new DateTime(1985, 8, 9),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumeroCamisa = 16, Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Matheus Thuler",        DataNascimento = new DateTime(1999, 2, 21), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumeroCamisa = 26, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "João Lucas",            DataNascimento = new DateTime(1991, 12, 30),Nacionalidade = "Brasil", Posicao = Posicao.Lateral,    NumeroCamisa = 32, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Rhodolfo",              DataNascimento = new DateTime(1986, 2, 13), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumeroCamisa = 44, Altura = 1.87m, Peso = 82m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Matheus Dantas",        DataNascimento = new DateTime(1998, 7, 15), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumeroCamisa = 55, Altura = 1.85m, Peso = 78m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Rafael Santos",         DataNascimento = new DateTime(1998, 4, 21), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,   NumeroCamisa = 58, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Willian Arão",          DataNascimento = new DateTime(1992, 7, 24), Nacionalidade = "Brasil", Posicao = Posicao.Volante,    NumeroCamisa = 5,  Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Éverton Ribeiro",       DataNascimento = new DateTime(1989, 4, 10), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumeroCamisa = 7,  Altura = 1.74m, Peso = 64m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Gerson",               DataNascimento = new DateTime(1997, 5, 20), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumeroCamisa = 8,  Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Diego",                DataNascimento = new DateTime(1985, 2, 15), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumeroCamisa = 10, Altura = 1.74m, Peso = 65m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Giorgian de Arrascaeta",DataNascimento = new DateTime(1994, 6, 1),  Nacionalidade = "Uruguai",Posicao = Posicao.Meia,       NumeroCamisa = 14, Altura = 1.75m, Peso = 71m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Vinícius Souza",        DataNascimento = new DateTime(2000, 4, 28), Nacionalidade = "Brasil", Posicao = Posicao.Volante,    NumeroCamisa = 15, Altura = 1.79m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Hugo Moura",           DataNascimento = new DateTime(1999, 6, 11), Nacionalidade = "Brasil", Posicao = Posicao.Volante,    NumeroCamisa = 17, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Reinier",              DataNascimento = new DateTime(2002, 1, 19), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumeroCamisa = 19, Altura = 1.76m, Peso = 68m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Robert Piris Da Motta",DataNascimento = new DateTime(1994, 6, 3),  Nacionalidade = "Paraguai",Posicao = Posicao.Volante,    NumeroCamisa = 25, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Pepê",                 DataNascimento = new DateTime(1998, 4, 15), Nacionalidade = "Brasil", Posicao = Posicao.Meia,       NumeroCamisa = 40, Altura = 1.79m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },

                    // Atacantes
                    new Jogador { Nome = "Gabriel Barbosa",      DataNascimento = new DateTime(1996, 8, 30), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumeroCamisa = 9,  Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Esquerdo,   TimeId = flamengo.Id },
                    new Jogador { Nome = "Vitinho",              DataNascimento = new DateTime(1993, 10, 9), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumeroCamisa = 11, Altura = 1.75m, Peso = 66m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Lucas Silva",          DataNascimento = new DateTime(1993, 1, 16), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumeroCamisa = 23, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Bruno Henrique",       DataNascimento = new DateTime(1990, 6, 30), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumeroCamisa = 27, Altura = 1.74m, Peso = 82m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Orlando Berrío",       DataNascimento = new DateTime(1991, 12, 21),Nacionalidade = "Colômbia",Posicao = Posicao.Atacante,  NumeroCamisa = 28, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Lincoln",              DataNascimento = new DateTime(1998, 2, 24), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumeroCamisa = 29, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id },
                    new Jogador { Nome = "Vitor Gabriel",        DataNascimento = new DateTime(1999, 8, 14), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,  NumeroCamisa = 54, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito,    TimeId = flamengo.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var realMadrid = context.Times.FirstOrDefault(t => t.Nome == "Real Madrid 2017");
            if (realMadrid != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Zinedine Zidane",       Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1972, 6, 23), TimeId = realMadrid.Id },
                    new ComissaoTecnica { Nome = "David Bettoni",        Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1971, 1, 18), TimeId = realMadrid.Id },
                    new ComissaoTecnica { Nome = "Antonio Pintus",       Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1960, 3, 10), TimeId = realMadrid.Id },
                    new ComissaoTecnica { Nome = "David Ferreyra",       Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1978, 9, 12), TimeId = realMadrid.Id },
                    new ComissaoTecnica { Nome = "Silvino Louro",        Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1959, 11, 6), TimeId = realMadrid.Id },
                    new ComissaoTecnica { Nome = "Alberto Pérez",        Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1975, 5,  5), TimeId = realMadrid.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Atacantes
                    new Jogador { Nome = "Cristiano Ronaldo",      DataNascimento = new DateTime(1985, 2, 5),   Nacionalidade = "Portugal", Posicao = Posicao.Atacante, NumeroCamisa = 7,  Altura = 1.87m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Karim Benzema",          DataNascimento = new DateTime(1987, 12, 19), Nacionalidade = "França",   Posicao = Posicao.Atacante, NumeroCamisa = 9,  Altura = 1.85m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Gareth Bale",            DataNascimento = new DateTime(1989, 7, 16),  Nacionalidade = "País de Gales", Posicao = Posicao.Atacante, NumeroCamisa = 11, Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "James Rodríguez",        DataNascimento = new DateTime(1991, 7, 12),  Nacionalidade = "Colômbia", Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Mariano",                DataNascimento = new DateTime(1993, 5, 1),   Nacionalidade = "Rep. Dominicana", Posicao = Posicao.Atacante, NumeroCamisa = 18, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

                    // Meias
                    new Jogador { Nome = "Toni Kroos",             DataNascimento = new DateTime(1990, 1, 4),   Nacionalidade = "Alemanha", Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Casemiro",               DataNascimento = new DateTime(1992, 2, 23),  Nacionalidade = "Brasil",   Posicao = Posicao.Volante, NumeroCamisa = 14, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Isco",                   DataNascimento = new DateTime(1992, 4, 21),  Nacionalidade = "Espanha",  Posicao = Posicao.Meia,    NumeroCamisa = 22, Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Luka Modrić",            DataNascimento = new DateTime(1985, 9, 9),   Nacionalidade = "Croácia",  Posicao = Posicao.Meia,    NumeroCamisa = 19, Altura = 1.72m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Marco Asensio",          DataNascimento = new DateTime(1996, 1, 21),  Nacionalidade = "Espanha",  Posicao = Posicao.Atacante, NumeroCamisa = 20, Altura = 1.78m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Mateo Kovačić",          DataNascimento = new DateTime(1994, 5, 6),   Nacionalidade = "Croácia",  Posicao = Posicao.Volante, NumeroCamisa = 16, Altura = 1.77m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

                    // Zagueiros e Laterais
                    new Jogador { Nome = "Sergio Ramos",           DataNascimento = new DateTime(1986, 3, 30),  Nacionalidade = "Espanha",  Posicao = Posicao.Zagueiro, NumeroCamisa = 4,  Altura = 1.84m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Raphaël Varane",         DataNascimento = new DateTime(1993, 4, 25),  Nacionalidade = "França",   Posicao = Posicao.Zagueiro, NumeroCamisa = 5,  Altura = 1.91m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Nacho",                  DataNascimento = new DateTime(1990, 1, 18),  Nacionalidade = "Espanha",  Posicao = Posicao.Zagueiro, NumeroCamisa = 6,  Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Pepe",                   DataNascimento = new DateTime(1983, 2, 26),  Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro, NumeroCamisa = 3,  Altura = 1.88m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Dani Carvajal",          DataNascimento = new DateTime(1992, 1, 11),  Nacionalidade = "Espanha",  Posicao = Posicao.Lateral,  NumeroCamisa = 2,  Altura = 1.73m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Marcelo",                DataNascimento = new DateTime(1988, 5, 12),  Nacionalidade = "Brasil",   Posicao = Posicao.Lateral,  NumeroCamisa = 12, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Fábio Coentrão",         DataNascimento = new DateTime(1988, 5, 11),  Nacionalidade = "Portugal", Posicao = Posicao.Lateral,  NumeroCamisa = 15, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Danilo",                 DataNascimento = new DateTime(1991, 7, 15),  Nacionalidade = "Brasil",   Posicao = Posicao.Lateral,  NumeroCamisa = 23, Altura = 1.84m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

                    // Goleiros
                    new Jogador { Nome = "Keylor Navas",           DataNascimento = new DateTime(1986, 12, 15),Nacionalidade = "Costa Rica",Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Kiko Casilla",           DataNascimento = new DateTime(1986, 10, 2), Nacionalidade = "Espanha",  Posicao = Posicao.Goleiro,  NumeroCamisa = 13, Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Rubén Yáñez",            DataNascimento = new DateTime(1993, 6, 22), Nacionalidade = "Espanha",  Posicao = Posicao.Goleiro,  NumeroCamisa = 25, Altura = 1.90m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },

                    // Jogadores Genéricos
                    new Jogador { Nome = "Andrés Gallardo",        DataNascimento = new DateTime(1995, 1, 1),  Nacionalidade = "Espanha",  Posicao = Posicao.Meia,    NumeroCamisa = 26, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Iker Villanueva",        DataNascimento = new DateTime(1995, 2, 1),  Nacionalidade = "Espanha",  Posicao = Posicao.Volante, NumeroCamisa = 27, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Santiago Olmedo",        DataNascimento = new DateTime(1995, 3, 1),  Nacionalidade = "Espanha",  Posicao = Posicao.Lateral, NumeroCamisa = 28, Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Bruno Calderón",         DataNascimento = new DateTime(1995, 4, 1),  Nacionalidade = "Espanha",  Posicao = Posicao.Zagueiro,NumeroCamisa = 29, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Lucas Echeverría",       DataNascimento = new DateTime(1995, 5, 1),  Nacionalidade = "Espanha",  Posicao = Posicao.Atacante,NumeroCamisa = 30, Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Tomás Riquelme",         DataNascimento = new DateTime(1995, 6, 1),  Nacionalidade = "Espanha",  Posicao = Posicao.Goleiro, NumeroCamisa = 31, Altura = 1.89m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Eduardo Soriano",        DataNascimento = new DateTime(1996, 7, 7),  Nacionalidade = "Espanha",  Posicao = Posicao.Meia,    NumeroCamisa = 32, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Francisco Orellana",     DataNascimento = new DateTime(1997, 3, 14), Nacionalidade = "Espanha",  Posicao = Posicao.Zagueiro,NumeroCamisa = 33, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Raúl Mena",              DataNascimento = new DateTime(1996, 9, 10), Nacionalidade = "Espanha",  Posicao = Posicao.Atacante,NumeroCamisa = 34, Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = realMadrid.Id },
                    new Jogador { Nome = "Iván Montoya",           DataNascimento = new DateTime(1994, 11, 22),Nacionalidade = "Espanha",  Posicao = Posicao.Lateral, NumeroCamisa = 35, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = realMadrid.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var barcelona = context.Times.FirstOrDefault(t => t.Nome == "Barcelona 2012");
            if (barcelona != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Xavi Hernández",       Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1980, 1, 25), TimeId = barcelona.Id },
                    new ComissaoTecnica { Nome = "Albert Ferrer",        Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1970, 6,  6), TimeId = barcelona.Id },
                    new ComissaoTecnica { Nome = "Ramón Cugat",          Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1948, 1,  1), TimeId = barcelona.Id },
                    new ComissaoTecnica { Nome = "Iñaki Goñi",           Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1982, 3, 14), TimeId = barcelona.Id },
                    new ComissaoTecnica { Nome = "Juan Carlos Unzué",    Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1966, 4,  5), TimeId = barcelona.Id },
                    new ComissaoTecnica { Nome = "Joan Blázquez",        Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1975, 7,  8), TimeId = barcelona.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Víctor Valdés",        DataNascimento = new DateTime(1982, 1, 14),  Nacionalidade = "Espanha", Posicao = Posicao.Goleiro,   NumeroCamisa = 1,  Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "José Manuel Pinto",    DataNascimento = new DateTime(1975, 11, 8),  Nacionalidade = "Espanha", Posicao = Posicao.Goleiro,   NumeroCamisa = 13, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },

                    // Defensores
                    new Jogador { Nome = "Dani Alves",           DataNascimento = new DateTime(1983, 5, 6),   Nacionalidade = "Brasil", Posicao = Posicao.Lateral,   NumeroCamisa = 2,  Altura = 1.72m, Peso = 68m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Javier Mascherano",    DataNascimento = new DateTime(1984, 6, 8),   Nacionalidade = "Argentina", Posicao = Posicao.Zagueiro, NumeroCamisa = 14, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Carles Puyol",         DataNascimento = new DateTime(1978, 4, 13),  Nacionalidade = "Espanha", Posicao = Posicao.Zagueiro, NumeroCamisa = 5,  Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Adriano Correia",      DataNascimento = new DateTime(1984, 10, 26), Nacionalidade = "Brasil", Posicao = Posicao.Lateral,   NumeroCamisa = 21, Altura = 1.74m, Peso = 72m, PePreferido = PePreferido.Esquerdo,   TimeId = barcelona.Id },
                    new Jogador { Nome = "Gerard Piqué",         DataNascimento = new DateTime(1987, 2, 2),   Nacionalidade = "Espanha", Posicao = Posicao.Zagueiro, NumeroCamisa = 3,  Altura = 1.94m, Peso = 85m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Éric Abidal",          DataNascimento = new DateTime(1979, 9, 11),  Nacionalidade = "França", Posicao = Posicao.Zagueiro, NumeroCamisa = 22, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Maxwell",              DataNascimento = new DateTime(1981, 8, 27),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,   NumeroCamisa = 6,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Esquerdo,   TimeId = barcelona.Id },
                    new Jogador { Nome = "Marc Bartra",          DataNascimento = new DateTime(1991, 1, 15),  Nacionalidade = "Espanha", Posicao = Posicao.Zagueiro, NumeroCamisa = 15, Altura = 1.81m, Peso = 74m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },

                    // Meio-campistas
                    new Jogador { Nome = "Xavi Hernández",       DataNascimento = new DateTime(1980, 1, 25),  Nacionalidade = "Espanha", Posicao = Posicao.Meia,     NumeroCamisa = 8,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Sergio Busquets",      DataNascimento = new DateTime(1988, 7, 16),  Nacionalidade = "Espanha", Posicao = Posicao.Volante,  NumeroCamisa = 16, Altura = 1.89m, Peso = 76m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Cesc Fàbregas",        DataNascimento = new DateTime(1987, 5, 4),   Nacionalidade = "Espanha", Posicao = Posicao.Meia,     NumeroCamisa = 4,  Altura = 1.79m, Peso = 75m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Thiago Alcântara",     DataNascimento = new DateTime(1991, 4, 11),  Nacionalidade = "Espanha", Posicao = Posicao.Meia,     NumeroCamisa = 12, Altura = 1.74m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Andrés Iniesta",       DataNascimento = new DateTime(1984, 5, 11),  Nacionalidade = "Espanha", Posicao = Posicao.Meia,     NumeroCamisa = 6,  Altura = 1.71m, Peso = 68m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Seydou Keita",         DataNascimento = new DateTime(1980, 1, 16),  Nacionalidade = "Mali",    Posicao = Posicao.Meia,     NumeroCamisa = 19, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Ibrahim Afellay",      DataNascimento = new DateTime(1986, 4, 2),   Nacionalidade = "Países Baixos", Posicao = Posicao.Meia, NumeroCamisa = 11, Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = barcelona.Id },
                    new Jogador { Nome = "Jonathan dos Santos",  DataNascimento = new DateTime(1990, 4, 26),  Nacionalidade = "México",  Posicao = Posicao.Meia,     NumeroCamisa = 25, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Sergi Roberto",        DataNascimento = new DateTime(1992, 2, 7),   Nacionalidade = "Espanha", Posicao = Posicao.Meia,     NumeroCamisa = 28, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },

                    // Atacantes
                    new Jogador { Nome = "Lionel Messi",         DataNascimento = new DateTime(1987, 6, 24),  Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 10, Altura = 1.70m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Pedro Rodríguez",      DataNascimento = new DateTime(1987, 7, 28),  Nacionalidade = "Espanha",   Posicao = Posicao.Atacante, NumeroCamisa = 17, Altura = 1.68m, Peso = 64m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Alexis Sánchez",       DataNascimento = new DateTime(1988, 12, 19), Nacionalidade = "Chile",     Posicao = Posicao.Atacante, NumeroCamisa = 14, Altura = 1.69m, Peso = 68m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "David Villa",          DataNascimento = new DateTime(1981, 12, 3),  Nacionalidade = "Espanha",   Posicao = Posicao.Atacante, NumeroCamisa = 7,  Altura = 1.70m, Peso = 70m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Cristian Tello",       DataNascimento = new DateTime(1991, 8, 11),  Nacionalidade = "Espanha",   Posicao = Posicao.Atacante, NumeroCamisa = 27, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito,    TimeId = barcelona.Id },
                    new Jogador { Nome = "Gerard Deulofeu",      DataNascimento = new DateTime(1994, 3, 13),  Nacionalidade = "Espanha",   Posicao = Posicao.Atacante, NumeroCamisa = 26, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Esquerdo,   TimeId = barcelona.Id },

                    // Jogadores Genéricos
                    new Jogador { Nome = "Raúl Fernández",     DataNascimento = new DateTime(1996, 1, 12), Nacionalidade = "Espanha", Posicao = Posicao.Goleiro,     NumeroCamisa = 36, Altura = 1.90m, Peso = 84m, PePreferido = PePreferido.Direito,  TimeId = barcelona.Id },
                    new Jogador { Nome = "Andrés Navarro",     DataNascimento = new DateTime(1996, 2, 20), Nacionalidade = "Espanha", Posicao = Posicao.Lateral,     NumeroCamisa = 37, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = barcelona.Id },
                    new Jogador { Nome = "Carlos Domínguez",   DataNascimento = new DateTime(1996, 3, 15), Nacionalidade = "Espanha", Posicao = Posicao.Zagueiro,    NumeroCamisa = 38, Altura = 1.86m, Peso = 81m, PePreferido = PePreferido.Direito,  TimeId = barcelona.Id },
                    new Jogador { Nome = "Mario Gallardo",     DataNascimento = new DateTime(1996, 4, 5),  Nacionalidade = "Espanha", Posicao = Posicao.Meia, NumeroCamisa = 39, Altura = 1.79m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = barcelona.Id },
                    new Jogador { Nome = "Javier Peña",        DataNascimento = new DateTime(1996, 5, 25), Nacionalidade = "Espanha", Posicao = Posicao.Atacante,    NumeroCamisa = 40, Altura = 1.81m, Peso = 77m, PePreferido = PePreferido.Direito,  TimeId = barcelona.Id },
                    new Jogador { Nome = "Héctor Lozano",      DataNascimento = new DateTime(1996, 6, 8),  Nacionalidade = "Espanha", Posicao = Posicao.Meia, NumeroCamisa = 41, Altura = 1.77m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = barcelona.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var vasco = context.Times.FirstOrDefault(t => t.Nome == "Vasco 2002");
            if (vasco != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Fábio Carille",       Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1973, 9, 26), TimeId = vasco.Id },
                    new ComissaoTecnica { Nome = "Bruno Lazaroni",      Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1980, 1, 13), TimeId = vasco.Id },
                    new ComissaoTecnica { Nome = "César Mendes",        Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1985, 5, 20), TimeId = vasco.Id },
                    new ComissaoTecnica { Nome = "Cyro Bueno",          Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1978, 3, 10), TimeId = vasco.Id },
                    new ComissaoTecnica { Nome = "Mateus Famer",        Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1982, 7, 15), TimeId = vasco.Id },
                    new ComissaoTecnica { Nome = "Rodrigo Sasson",      Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1979, 11, 5), TimeId = vasco.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();


                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Fábio",               DataNascimento = new DateTime(1980, 9, 30), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Hélton",              DataNascimento = new DateTime(1978, 5, 18), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 12, Altura = 1.90m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Márcio",              DataNascimento = new DateTime(1971, 3, 16), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 22, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },

                    // Defensores
                    new Jogador { Nome = "André Leone",         DataNascimento = new DateTime(1979, 2, 12), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 3,  Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Claudemir",           DataNascimento = new DateTime(1984, 8, 17), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 4,  Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Edinho",              DataNascimento = new DateTime(1979, 10, 30),Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 2,  Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Géder",               DataNascimento = new DateTime(1978, 4, 23), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 5,  Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "João Carlos",         DataNascimento = new DateTime(1982, 1, 1),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 6,  Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Jorginho",            DataNascimento = new DateTime(1964, 8, 17), Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 13, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Léo Moura",           DataNascimento = new DateTime(1978, 10, 23),Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 14, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Leonardo Henrique",   DataNascimento = new DateTime(1977, 7, 16), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 15, Altura = 1.84m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Marcelo Magalhães",   DataNascimento = new DateTime(1979, 8, 7),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 16, Altura = 1.80m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Wagner",              DataNascimento = new DateTime(1974, 3, 6),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 17, Altura = 1.86m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Diogo Siston",        DataNascimento = new DateTime(1981, 1, 25), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Donizete Oliveira",   DataNascimento = new DateTime(1968, 2, 21), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 10, Altura = 1.79m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Felipe Loureiro",     DataNascimento = new DateTime(1977, 9, 2),  Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 11, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Léo Lima",            DataNascimento = new DateTime(1982, 1, 14), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 18, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Ricardo Bóvio",       DataNascimento = new DateTime(1982, 1, 17), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 19, Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Rogério Corrêa",      DataNascimento = new DateTime(1981, 3, 27), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 20, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Wederson",            DataNascimento = new DateTime(1981, 7, 22), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 21, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },

                    // Atacantes
                    new Jogador { Nome = "Alex Oliveira",       DataNascimento = new DateTime(1974, 1, 21), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Bebeto",              DataNascimento = new DateTime(1964, 2, 16), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 12, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Cadu",                DataNascimento = new DateTime(1982, 4, 23), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 13, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Ely Thadeu",          DataNascimento = new DateTime(1982, 8, 12), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 14, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Léo Macaé",           DataNascimento = new DateTime(1983, 3, 28), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 15, Altura = 1.77m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Luciano",             DataNascimento = new DateTime(1969, 2, 2),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 16, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Romário",             DataNascimento = new DateTime(1966, 1, 29), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 17, Altura = 1.83m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Souza",               DataNascimento = new DateTime(1982, 3, 4),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 18, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },
                    new Jogador { Nome = "Valdir",              DataNascimento = new DateTime(1972, 3, 15), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 19, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = vasco.Id },

                    // Genérico para completar 30
                    new Jogador { Nome = "Jogador Genérico 30",DataNascimento = new DateTime(1995, 1, 1), Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumeroCamisa = 30, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = vasco.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var liverpool = context.Times.FirstOrDefault(t => t.Nome == "Liverpool 2019");
            if (liverpool != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Arne Slot",           Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1978, 9, 17), TimeId = liverpool.Id },
                    new ComissaoTecnica { Nome = "Sipke Hulshoff",      Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1975, 1, 1),  TimeId = liverpool.Id },
                    new ComissaoTecnica { Nome = "Fabian Otte",         Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1990, 1, 1),  TimeId = liverpool.Id },
                    new ComissaoTecnica { Nome = "Andreas Kornmayer",   Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1975, 1, 1),  TimeId = liverpool.Id },
                    new ComissaoTecnica { Nome = "Dr. Andreas Schlumberger", Cargo = Cargo.Fisiologista,  DataNascimento = new DateTime(1966, 1, 1),  TimeId = liverpool.Id },
                    new ComissaoTecnica { Nome = "Lee Nobes",           Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1970, 1, 1),  TimeId = liverpool.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Alisson Becker",      DataNascimento = new DateTime(1992, 10, 2),  Nacionalidade = "Brasil",  Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.91m, Peso = 91m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Simon Mignolet",      DataNascimento = new DateTime(1988, 3, 6),   Nacionalidade = "Bélgica", Posicao = Posicao.Goleiro,  NumeroCamisa = 13, Altura = 1.93m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Caoimhín Kelleher",   DataNascimento = new DateTime(1998, 11, 23), Nacionalidade = "Irlanda", Posicao = Posicao.Goleiro,  NumeroCamisa = 62, Altura = 1.88m, Peso = 79m, PePreferido = PePreferido.Esquerdo,  TimeId = liverpool.Id },

                    // Defensores
                    new Jogador { Nome = "Nathaniel Clyne",     DataNascimento = new DateTime(1991, 4, 5),   Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral,  NumeroCamisa = 2,  Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Virgil van Dijk",     DataNascimento = new DateTime(1991, 7, 8),   Nacionalidade = "Países Baixos", Posicao = Posicao.Zagueiro, NumeroCamisa = 4,  Altura = 1.93m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Andrew Robertson",     DataNascimento = new DateTime(1994, 3, 11),  Nacionalidade = "Escócia", Posicao = Posicao.Lateral,  NumeroCamisa = 6,  Altura = 1.78m, Peso = 69m, PePreferido = PePreferido.Esquerdo,  TimeId = liverpool.Id },
                    new Jogador { Nome = "Joe Gomez",           DataNascimento = new DateTime(1997, 5, 23),  Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro, NumeroCamisa = 12, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Alberto Moreno",       DataNascimento = new DateTime(1992, 7, 5),   Nacionalidade = "Espanha", Posicao = Posicao.Lateral,  NumeroCamisa = 18, Altura = 1.70m, Peso = 65m, PePreferido = PePreferido.Esquerdo,  TimeId = liverpool.Id },
                    new Jogador { Nome = "Dejan Lovren",         DataNascimento = new DateTime(1989, 7, 5),   Nacionalidade = "Croácia", Posicao = Posicao.Zagueiro, NumeroCamisa = 26, Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Joël Matip",           DataNascimento = new DateTime(1991, 8, 8),   Nacionalidade = "Camarões", Posicao = Posicao.Zagueiro, NumeroCamisa = 32, Altura = 1.95m, Peso = 99m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Trent Alexander‑Arnold",DataNascimento = new DateTime(1998, 10, 7), Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral, NumeroCamisa = 66, Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Fabinho",              DataNascimento = new DateTime(1993, 10, 23), Nacionalidade = "Brasil",  Posicao = Posicao.Volante, NumeroCamisa = 3,  Altura = 1.88m, Peso = 89m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Georginio Wijnaldum",  DataNascimento = new DateTime(1990, 11, 11), Nacionalidade = "Países Baixos", Posicao = Posicao.Meia, NumeroCamisa = 5,  Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "James Milner",         DataNascimento = new DateTime(1986, 1, 4),   Nacionalidade = "Inglaterra", Posicao = Posicao.Volante, NumeroCamisa = 7,  Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Naby Keïta",           DataNascimento = new DateTime(1995, 2, 10),  Nacionalidade = "Guiné",   Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.72m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Jordan Henderson",     DataNascimento = new DateTime(1990, 6, 17),  Nacionalidade = "Inglaterra", Posicao = Posicao.Volante, NumeroCamisa = 14, Altura = 1.82m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Adam Lallana",         DataNascimento = new DateTime(1988, 5, 10),  Nacionalidade = "Inglaterra", Posicao = Posicao.Meia,    NumeroCamisa = 20, Altura = 1.72m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Alex Oxlade‑Chamberlain",DataNascimento = new DateTime(1993, 8, 15), Nacionalidade = "Inglaterra", Posicao = Posicao.Meia,    NumeroCamisa = 21, Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Xherdan Shaqiri",      DataNascimento = new DateTime(1991, 10, 10), Nacionalidade = "Suíça",   Posicao = Posicao.Meia,    NumeroCamisa = 23, Altura = 1.69m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Curtis Jones",         DataNascimento = new DateTime(2001, 1, 30),  Nacionalidade = "Inglaterra", Posicao = Posicao.Meia,    NumeroCamisa = 48, Altura = 1.88m, Peso = 87m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },

                    // Atacantes
                    new Jogador { Nome = "Roberto Firmino",      DataNascimento = new DateTime(1991, 10, 2),  Nacionalidade = "Brasil",  Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Sadio Mané",           DataNascimento = new DateTime(1992, 4, 10),  Nacionalidade = "Senegal", Posicao = Posicao.Atacante,NumeroCamisa = 10, Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Mohamed Salah",        DataNascimento = new DateTime(1992, 6, 15),  Nacionalidade = "Egito",   Posicao = Posicao.Atacante,NumeroCamisa = 11, Altura = 1.75m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Daniel Sturridge",     DataNascimento = new DateTime(1989, 9, 1),   Nacionalidade = "Inglaterra", Posicao = Posicao.Atacante,NumeroCamisa = 15, Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },
                    new Jogador { Nome = "Divock Origi",         DataNascimento = new DateTime(1995, 4, 18),  Nacionalidade = "Bélgica", Posicao = Posicao.Atacante,NumeroCamisa = 27, Altura = 1.84m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = liverpool.Id },

                    // Jogadores Genéricos
                    new Jogador { Nome = "James Whitaker",     DataNascimento = new DateTime(1995, 3, 1), Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral,   NumeroCamisa = 28, Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool.Id },
                    new Jogador { Nome = "Oliver Chambers",    DataNascimento = new DateTime(1995, 4, 1), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro,  NumeroCamisa = 29, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito,  TimeId = liverpool.Id },
                    new Jogador { Nome = "Ethan Woodward",     DataNascimento = new DateTime(1995, 5, 1), Nacionalidade = "Inglaterra", Posicao = Posicao.Atacante,  NumeroCamisa = 30, Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito,  TimeId = liverpool.Id },
                    new Jogador { Nome = "George Hargreaves",  DataNascimento = new DateTime(1995, 6, 1), Nacionalidade = "Inglaterra", Posicao = Posicao.Goleiro,   NumeroCamisa = 31, Altura = 1.89m, Peso = 85m, PePreferido = PePreferido.Direito,  TimeId = liverpool.Id },
                    new Jogador { Nome = "Thomas Redgrave",    DataNascimento = new DateTime(1995, 7, 1), Nacionalidade = "Inglaterra", Posicao = Posicao.Volante, NumeroCamisa = 32, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = liverpool.Id }

                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var bayern = context.Times.FirstOrDefault(t => t.Nome == "Bayern Munich 2020");
            if (bayern != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Vincent Kompany",        Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1986, 4, 10), TimeId = bayern.Id },
                    new ComissaoTecnica { Nome = "Aaron Danks",            Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1985, 6, 20), TimeId = bayern.Id },
                    new ComissaoTecnica { Nome = "Michael Rechner",        Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1980, 1, 1),  TimeId = bayern.Id },
                    new ComissaoTecnica { Nome = "Bram Geers",             Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1993, 1, 1),  TimeId = bayern.Id },
                    new ComissaoTecnica { Nome = "Walter Gfrerer",         Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1975, 1, 1),  TimeId = bayern.Id },
                    new ComissaoTecnica { Nome = "Rodyse Munienge",        Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1980, 1, 1),  TimeId = bayern.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Manuel Neuer",           DataNascimento = new DateTime(1986, 3, 27),  Nacionalidade = "Alemanha", Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.93m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Sven Ulreich",          DataNascimento = new DateTime(1988, 10, 3),  Nacionalidade = "Alemanha", Posicao = Posicao.Goleiro,  NumeroCamisa = 26, Altura = 1.92m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Christian Früchtl",     DataNascimento = new DateTime(1998, 12, 28), Nacionalidade = "Alemanha", Posicao = Posicao.Goleiro,  NumeroCamisa = 36, Altura = 1.96m, Peso = 89m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Ron-Thorben Hofmann",    DataNascimento = new DateTime(1996, 5, 23),  Nacionalidade = "Alemanha", Posicao = Posicao.Goleiro,  NumeroCamisa = 39, Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },

                    // Defensores
                    new Jogador { Nome = "Álvaro Odriozola",      DataNascimento = new DateTime(1995, 12, 14), Nacionalidade = "Espanha", Posicao = Posicao.Lateral,  NumeroCamisa = 2,  Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Niklas Süle",           DataNascimento = new DateTime(1995, 9, 3),   Nacionalidade = "Alemanha", Posicao = Posicao.Zagueiro, NumeroCamisa = 4,  Altura = 1.95m, Peso = 113m,PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Benjamin Pavard",       DataNascimento = new DateTime(1996, 3, 28),  Nacionalidade = "França", Posicao = Posicao.Zagueiro, NumeroCamisa = 5,  Altura = 1.86m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Jérôme Boateng",        DataNascimento = new DateTime(1988, 9, 3),   Nacionalidade = "Alemanha", Posicao = Posicao.Zagueiro, NumeroCamisa = 17, Altura = 1.92m, Peso = 96m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Alphonso Davies",       DataNascimento = new DateTime(2000, 11, 2),  Nacionalidade = "Canadá", Posicao = Posicao.Lateral,  NumeroCamisa = 19, Altura = 1.81m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = bayern.Id },
                    new Jogador { Nome = "David Alaba",           DataNascimento = new DateTime(1992, 6, 24),  Nacionalidade = "Áustria", Posicao = Posicao.Lateral,  NumeroCamisa = 27, Altura = 1.80m, Peso = 78m, PePreferido = PePreferido.Esquerdo, TimeId = bayern.Id },
                    new Jogador { Nome = "Lukas Mai",             DataNascimento = new DateTime(2000, 1, 31),  Nacionalidade = "Alemanha", Posicao = Posicao.Zagueiro, NumeroCamisa = 33, Altura = 1.91m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Chris Richards",        DataNascimento = new DateTime(2000, 4, 28),  Nacionalidade = "EUA", Posicao = Posicao.Zagueiro, NumeroCamisa = 41, Altura = 1.91m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },

                    // Meio-campistas
                    new Jogador { Nome = "Thiago Alcântara",      DataNascimento = new DateTime(1991, 4, 11),  Nacionalidade = "Espanha", Posicao = Posicao.Meia,    NumeroCamisa = 6,  Altura = 1.71m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Javi Martínez",         DataNascimento = new DateTime(1988, 9, 2),   Nacionalidade = "Espanha", Posicao = Posicao.Volante, NumeroCamisa = 8,  Altura = 1.90m, Peso = 87m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Michaël Cuisance",      DataNascimento = new DateTime(2000, 7, 16),  Nacionalidade = "França", Posicao = Posicao.Meia,    NumeroCamisa = 11, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Ivan Perišić",          DataNascimento = new DateTime(1989, 2, 2),   Nacionalidade = "Croácia", Posicao = Posicao.Meia,    NumeroCamisa = 14, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Corentin Tolisso",      DataNascimento = new DateTime(1994, 8, 3),   Nacionalidade = "França", Posicao = Posicao.Meia,    NumeroCamisa = 24, Altura = 1.81m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Leon Goretzka",         DataNascimento = new DateTime(1995, 2, 6),   Nacionalidade = "Alemanha", Posicao = Posicao.Meia,    NumeroCamisa = 18, Altura = 1.89m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Sarpreet Singh",        DataNascimento = new DateTime(1999, 1, 11),  Nacionalidade = "Nova Zelândia",Posicao = Posicao.Meia, NumeroCamisa = 28, Altura = 1.70m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Jeong Woo-Yeong",       DataNascimento = new DateTime(1999, 6, 17),  Nacionalidade = "Coreia do Sul",Posicao = Posicao.Meia,NumeroCamisa = 30, Altura = 1.79m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Joshua Kimmich",        DataNascimento = new DateTime(1995, 2, 8),   Nacionalidade = "Alemanha", Posicao = Posicao.Volante, NumeroCamisa = 32, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Kingsley Coman",        DataNascimento = new DateTime(1996, 6, 13),  Nacionalidade = "França", Posicao = Posicao.Meia,    NumeroCamisa = 29, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Oliver Batista Meier",  DataNascimento = new DateTime(2001, 8, 1),   Nacionalidade = "Alemanha", Posicao = Posicao.Meia,    NumeroCamisa = 34, Altura = 1.82m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },

                    // Atacantes
                    new Jogador { Nome = "Robert Lewandowski",    DataNascimento = new DateTime(1988, 8, 21),  Nacionalidade = "Polônia", Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Thomas Müller",         DataNascimento = new DateTime(1989, 9, 13),  Nacionalidade = "Alemanha", Posicao = Posicao.Atacante,NumeroCamisa = 25, Altura = 1.85m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Philippe Coutinho",     DataNascimento = new DateTime(1992, 6, 12),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 10, Altura = 1.72m, Peso = 60m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Jann-Fiete Arp",        DataNascimento = new DateTime(2000, 2, 6),   Nacionalidade = "Alemanha", Posicao = Posicao.Atacante,NumeroCamisa = 15, Altura = 1.83m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Leon Dajaku",           DataNascimento = new DateTime(2001, 7, 19),  Nacionalidade = "Alemanha", Posicao = Posicao.Atacante,NumeroCamisa = 16, Altura = 1.80m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Serge Gnabry",          DataNascimento = new DateTime(1995, 7, 14),  Nacionalidade = "Alemanha", Posicao = Posicao.Atacante,NumeroCamisa = 22, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = bayern.Id },
                    new Jogador { Nome = "Joshua Zirkzee",        DataNascimento = new DateTime(2001, 5, 22),  Nacionalidade = "Países Baixos", Posicao = Posicao.Atacante,NumeroCamisa = 35, Altura = 1.93m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = bayern.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }


            var milan = context.Times.FirstOrDefault(t => t.Nome == "Milan 1989");
            if (milan != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Sérgio Conceição",       Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1974, 11, 15), TimeId = milan.Id },
                    new ComissaoTecnica { Nome = "Siramana Dembélé",       Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1977, 1, 1),   TimeId = milan.Id },
                    new ComissaoTecnica { Nome = "Diamantino Figueiredo",  Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1973, 1, 1),   TimeId = milan.Id },
                    new ComissaoTecnica { Nome = "Lorenzo Francini",       Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1980, 1, 1),   TimeId = milan.Id },
                    new ComissaoTecnica { Nome = "Eduardo Oliveira",       Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1985, 1, 1),   TimeId = milan.Id },
                    new ComissaoTecnica { Nome = "Arturo Gerosa",          Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1982, 1, 1),   TimeId = milan.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Giovanni Galli",            DataNascimento = new DateTime(1958, 3, 29), Nacionalidade = "Itália", Posicao = Posicao.Goleiro,  NumeroCamisa = 1, Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Davide Pinato",             DataNascimento = new DateTime(1964, 6, 18), Nacionalidade = "Itália", Posicao = Posicao.Goleiro,  NumeroCamisa = 2,Altura = 1.85m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Francesco Antonioli",       DataNascimento = new DateTime(1974, 1, 14), Nacionalidade = "Itália", Posicao = Posicao.Goleiro,  NumeroCamisa = 3, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = milan.Id },

                    // Defensores
                    new Jogador { Nome = "Mauro Tassotti",            DataNascimento = new DateTime(1964, 5, 17), Nacionalidade = "Itália", Posicao = Posicao.Lateral,  NumeroCamisa = 4,Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Alessandro Costacurta",     DataNascimento = new DateTime(1966, 4, 24), Nacionalidade = "Itália", Posicao = Posicao.Zagueiro, NumeroCamisa = 5,Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Franco Baresi",             DataNascimento = new DateTime(1960, 5, 8),  Nacionalidade = "Itália", Posicao = Posicao.Zagueiro, NumeroCamisa = 6,Altura = 1.76m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = milan.Id },
                    new Jogador { Nome = "Paolo Maldini",             DataNascimento = new DateTime(1968, 6, 26), Nacionalidade = "Itália", Posicao = Posicao.Zagueiro, NumeroCamisa = 7,Altura = 1.86m, Peso = 78m, PePreferido = PePreferido.Esquerdo, TimeId = milan.Id },
                    new Jogador { Nome = "Paolo Mussi",               DataNascimento = new DateTime(1968, 3, 16), Nacionalidade = "Itália", Posicao = Posicao.Zagueiro, NumeroCamisa = 8,Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "F. Galli",                  DataNascimento = new DateTime(1965, 7, 12), Nacionalidade = "Itália", Posicao = Posicao.Zagueiro, NumeroCamisa = 9,Altura = 1.84m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Bianchi",                   DataNascimento = new DateTime(1965, 2, 20), Nacionalidade = "Suíça",  Posicao = Posicao.Zagueiro, NumeroCamisa = 10,Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = milan.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Angelo Colombo",            DataNascimento = new DateTime(1961, 4, 2),  Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 11,Altura = 1.81m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Carlo Ancelotti",           DataNascimento = new DateTime(1959, 6, 10), Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 12,Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Frank Rijkaard",            DataNascimento = new DateTime(1962, 5, 30), Nacionalidade = "Holanda",Posicao = Posicao.Meia,    NumeroCamisa = 13,Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Alberigo Evani",            DataNascimento = new DateTime(1963, 12, 1), Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 14,Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Esquerdo,TimeId = milan.Id },
                    new Jogador { Nome = "Roberto Donadoni",          DataNascimento = new DateTime(1963, 2, 9),  Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 15,Altura = 1.74m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Lantignotti",               DataNascimento = new DateTime(1967, 8, 18), Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 16,Altura = 1.77m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Viviani",                   DataNascimento = new DateTime(1966, 3, 15), Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 17,Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Albertini",                 DataNascimento = new DateTime(1970, 11, 23),Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 18,Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = milan.Id },

                    // Atacantes
                    new Jogador { Nome = "Ruud Gullit",               DataNascimento = new DateTime(1962, 9, 1),  Nacionalidade = "Holanda",Posicao = Posicao.Atacante,NumeroCamisa = 19, Altura = 1.91m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Marco van Basten",          DataNascimento = new DateTime(1964, 10, 31),Nacionalidade = "Holanda",Posicao = Posicao.Atacante,NumeroCamisa = 20, Altura = 1.88m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Pietro Paolo Virdis",       DataNascimento = new DateTime(1957, 5, 23), Nacionalidade = "Itália", Posicao = Posicao.Atacante,NumeroCamisa = 21,Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Graziano Mannari",          DataNascimento = new DateTime(1969, 1, 29), Nacionalidade = "Itália", Posicao = Posicao.Atacante,NumeroCamisa = 22,Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Stefano Cappellini",        DataNascimento = new DateTime(1966, 4, 1),  Nacionalidade = "Itália", Posicao = Posicao.Atacante,NumeroCamisa = 23,Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan.Id },

                    // Genéricos
                    new Jogador { Nome = "Luca Bernardi",             DataNascimento = new DateTime(1990, 1, 1), Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 24, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Marco Rinaldi",             DataNascimento = new DateTime(1990, 2, 1), Nacionalidade = "Itália", Posicao = Posicao.Volante, NumeroCamisa = 25, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Fabio Silvestri",           DataNascimento = new DateTime(1990, 3, 1), Nacionalidade = "Itália", Posicao = Posicao.Lateral, NumeroCamisa = 26, Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = milan.Id },
                    new Jogador { Nome = "Riccardo Mancini",          DataNascimento = new DateTime(1990, 4, 1), Nacionalidade = "Itália", Posicao = Posicao.Zagueiro,NumeroCamisa = 27, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Antonio De Luca",           DataNascimento = new DateTime(1990, 5, 1), Nacionalidade = "Itália", Posicao = Posicao.Atacante,NumeroCamisa = 28, Altura = 1.80m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Nicola Greco",              DataNascimento = new DateTime(1990, 6, 1), Nacionalidade = "Itália", Posicao = Posicao.Meia,    NumeroCamisa = 29, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = milan.Id },
                    new Jogador { Nome = "Giulio Marchetti",          DataNascimento = new DateTime(1990, 7, 1), Nacionalidade = "Itália", Posicao = Posicao.Goleiro, NumeroCamisa = 30, Altura = 1.80m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = milan.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }


            var manutd = context.Times.FirstOrDefault(t => t.Nome == "Manchester United 1999");
            if (manutd != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Ruben Amorim",       Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1985, 1, 27),  TimeId = manutd.Id },
                    new ComissaoTecnica { Nome = "René Hake",          Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1971, 12, 18), TimeId = manutd.Id },
                    new ComissaoTecnica { Nome = "Michael Clegg",      Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1977, 7,  3),  TimeId = manutd.Id },
                    new ComissaoTecnica { Nome = "Jelle ten Rouwelaar",Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1980, 12, 24),TimeId = manutd.Id },
                    new ComissaoTecnica { Nome = "Samantha Clark",     Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1980, 5, 12),  TimeId = manutd.Id },
                    new ComissaoTecnica { Nome = "Jordan Reece",       Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1989, 4,  2),  TimeId = manutd.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Peter Schmeichel",           DataNascimento = new DateTime(1963, 11, 18), Nacionalidade = "Dinamarca", Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.93m, Peso = 92m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Raimond van der Gouw",       DataNascimento = new DateTime(1963, 3, 24),  Nacionalidade = "Países Baixos", Posicao = Posicao.Goleiro,  NumeroCamisa = 17, Altura = 1.98m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Nick Culkin",                DataNascimento = new DateTime(1978, 11, 18), Nacionalidade = "Inglaterra", Posicao = Posicao.Goleiro,  NumeroCamisa = 31, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },

                    // Defensores
                    new Jogador { Nome = "Gary Neville",               DataNascimento = new DateTime(1975, 2, 18),  Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral,  NumeroCamisa = 2,  Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Denis Irwin",                DataNascimento = new DateTime(1965, 10, 31), Nacionalidade = "Irlanda", Posicao = Posicao.Zagueiro,   NumeroCamisa = 3,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Esquerdo, TimeId = manutd.Id },
                    new Jogador { Nome = "David May",                  DataNascimento = new DateTime(1968, 12, 24), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro,   NumeroCamisa = 4,  Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Ronny Johnsen",              DataNascimento = new DateTime(1969, 6, 10),  Nacionalidade = "Noruega", Posicao = Posicao.Zagueiro,   NumeroCamisa = 5,  Altura = 1.83m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Jaap Stam",                  DataNascimento = new DateTime(1972, 7, 17),  Nacionalidade = "Países Baixos", Posicao = Posicao.Zagueiro, NumeroCamisa = 6,  Altura = 1.91m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Phil Neville",               DataNascimento = new DateTime(1977, 1, 21),  Nacionalidade = "Inglaterra", Posicao = Posicao.Lateral,  NumeroCamisa = 12, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "John Curtis",                DataNascimento = new DateTime(1978, 12, 9),  Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro,   NumeroCamisa = 29, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Wes Brown",                  DataNascimento = new DateTime(1979, 10, 13), Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro,   NumeroCamisa = 30, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Chris Casper",               DataNascimento = new DateTime(1975, 4, 18),  Nacionalidade = "Inglaterra", Posicao = Posicao.Zagueiro,   NumeroCamisa = 26, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Henning Berg",               DataNascimento = new DateTime(1969, 11, 1),  Nacionalidade = "Noruega", Posicao = Posicao.Zagueiro,     NumeroCamisa = 21, Altura = 1.89m, Peso = 86m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "David Beckham",              DataNascimento = new DateTime(1975, 5, 2),   Nacionalidade = "Inglaterra", Posicao = Posicao.Meia,     NumeroCamisa = 7,  Altura = 1.70m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Nicky Butt",                 DataNascimento = new DateTime(1975, 1, 21),  Nacionalidade = "Inglaterra", Posicao = Posicao.Meia,     NumeroCamisa = 8,  Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Ryan Giggs",                 DataNascimento = new DateTime(1973, 11, 29), Nacionalidade = "País de Gales", Posicao = Posicao.Meia,  NumeroCamisa = 11, Altura = 1.70m, Peso = 64m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Jordi Cruyff",               DataNascimento = new DateTime(1974, 2, 9),   Nacionalidade = "Holanda", Posicao = Posicao.Meia,    NumeroCamisa = 14, Altura = 1.79m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = manutd.Id },
                    new Jogador { Nome = "Jesper Blomqvist",           DataNascimento = new DateTime(1974, 8, 5),   Nacionalidade = "Suécia", Posicao = Posicao.Meia,      NumeroCamisa = 15, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Roy Keane",                  DataNascimento = new DateTime(1971, 8, 10),  Nacionalidade = "Irlanda", Posicao = Posicao.Volante,  NumeroCamisa = 16, Altura = 1.70m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Paul Scholes",               DataNascimento = new DateTime(1974, 11, 16), Nacionalidade = "Inglaterra", Posicao = Posicao.Meia, NumeroCamisa = 18, Altura = 1.68m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Philip Mulryne",             DataNascimento = new DateTime(1978, 11, 20), Nacionalidade = "Irlanda do Norte", Posicao = Posicao.Meia, NumeroCamisa = 28, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Mark Wilson",                DataNascimento = new DateTime(1979, 9, 12),  Nacionalidade = "Escócia", Posicao = Posicao.Meia,    NumeroCamisa = 33, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Jonathan Greening",          DataNascimento = new DateTime(1979, 1, 19),  Nacionalidade = "Inglaterra", Posicao = Posicao.Meia,NumeroCamisa = 34, Altura = 1.77m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },

                    // Atacantes
                    new Jogador { Nome = "Andy Cole",                  DataNascimento = new DateTime(1971, 1, 15),  Nacionalidade = "Inglaterra", Posicao = Posicao.Atacante, NumeroCamisa = 9,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Teddy Sheringham",           DataNascimento = new DateTime(1966, 7, 2),   Nacionalidade = "Inglaterra", Posicao = Posicao.Atacante, NumeroCamisa = 10, Altura = 1.83m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Dwight Yorke",               DataNascimento = new DateTime(1971, 11, 3),  Nacionalidade = "Trinidad e Tobago", Posicao = Posicao.Atacante, NumeroCamisa = 19, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Ole Gunnar Solskjær",        DataNascimento = new DateTime(1973, 2, 26),  Nacionalidade = "Noruega", Posicao = Posicao.Atacante, NumeroCamisa = 20, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Erik Nevland",               DataNascimento = new DateTime(1977, 11, 20), Nacionalidade = "Noruega", Posicao = Posicao.Atacante, NumeroCamisa = 22, Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Alex Notman",                DataNascimento = new DateTime(1970, 12, 27), Nacionalidade = "Escócia", Posicao = Posicao.Atacante, NumeroCamisa = 29, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Ronnie Wallwork",            DataNascimento = new DateTime(1977, 8, 11),  Nacionalidade = "Inglaterra", Posicao = Posicao.Atacante, NumeroCamisa = 30, Altura = 1.77m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = manutd.Id },
                    new Jogador { Nome = "Danny Higginbotham",         DataNascimento = new DateTime(1978, 2, 20),  Nacionalidade = "País de Gales", Posicao = Posicao.Atacante, NumeroCamisa = 38, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = manutd.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var santos = context.Times.FirstOrDefault(t => t.Nome == "Santos 1962");
            if (santos != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "César Sampaio",      Cargo = Cargo.Treinador,         DataNascimento = new DateTime(1968, 3, 31),  TimeId = santos.Id },
                    new ComissaoTecnica { Nome = "Sérgio Chulapa",     Cargo = Cargo.Auxiliar,          DataNascimento = new DateTime(1953, 12, 23), TimeId = santos.Id },
                    new ComissaoTecnica { Nome = "Guilherme Gomes",    Cargo = Cargo.PreparadorFisico,  DataNascimento = new DateTime(1980, 6, 15),  TimeId = santos.Id },
                    new ComissaoTecnica { Nome = "José Belman",        Cargo = Cargo.TreinadorGoleiros, DataNascimento = new DateTime(1977, 5, 10),  TimeId = santos.Id },
                    new ComissaoTecnica { Nome = "Fernanda Lima",      Cargo = Cargo.Fisiologista,      DataNascimento = new DateTime(1985, 4, 20),  TimeId = santos.Id },
                    new ComissaoTecnica { Nome = "Rodrigo Silva",      Cargo = Cargo.Fisioterapeuta,    DataNascimento = new DateTime(1990, 9, 5),   TimeId = santos.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Gilmar",           DataNascimento = new DateTime(1930,8,22),  Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.87m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Laércio",          DataNascimento = new DateTime(1931,3,1),   Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 12, Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Silas Pereira",    DataNascimento = new DateTime(1934,9,12),  Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 22, Altura = 1.82m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = santos.Id },

                    // Defensores
                    new Jogador { Nome = "Calvet",           DataNascimento = new DateTime(1934,11,3),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 3,  Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Dalmo",            DataNascimento = new DateTime(1932,10,19), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 4,  Altura = 1.79m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Figueiró",         DataNascimento = new DateTime(1934,8,22),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 5,  Altura = 1.81m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Getúlio",          DataNascimento = new DateTime(1931,7,7),   Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 6,  Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Ismael",           DataNascimento = new DateTime(1938,2,7),   Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 13, Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Mauro Ramos",      DataNascimento = new DateTime(1930,8,30),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 14, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Olavo",            DataNascimento = new DateTime(1927,11,9),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 15, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Pavão",            DataNascimento = new DateTime(1929,1,4),   Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 16, Altura = 1.83m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Zé Carlos",        DataNascimento = new DateTime(1938,5,23),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 17, Altura = 1.84m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = santos.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Cabralzinho",      DataNascimento = new DateTime(1945,1,2),   Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Dorval",           DataNascimento = new DateTime(1935,2,26),  Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Elizeu",           DataNascimento = new DateTime(1945,10,17), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 11, Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Formiga",          DataNascimento = new DateTime(1930,11,11), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 12, Altura = 1.77m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Lima",             DataNascimento = new DateTime(1942,1,18),  Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 18, Altura = 1.74m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Mengálvio",        DataNascimento = new DateTime(1939,12,17), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 19, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Urubatão",         DataNascimento = new DateTime(1931,3,31),  Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 20, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Zito",             DataNascimento = new DateTime(1932,8,8),   Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 21, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Esquerdo, TimeId = santos.Id },

                    // Atacantes
                    new Jogador { Nome = "Coutinho",         DataNascimento = new DateTime(1943,6,11),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.71m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Nenê",             DataNascimento = new DateTime(1942,2,1),   Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 10, Altura = 1.69m, Peso = 67m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Osvaldo",          DataNascimento = new DateTime(1937,10,5),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 11, Altura = 1.70m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Pagão",            DataNascimento = new DateTime(1934,10,7),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 14, Altura = 1.68m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Pelé",             DataNascimento = new DateTime(1940,10,23), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 10, Altura = 1.73m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = santos.Id },
                    new Jogador { Nome = "Pepe",             DataNascimento = new DateTime(1935,2,25),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 15, Altura = 1.74m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Tite",             DataNascimento = new DateTime(1930,6,4),   Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 16, Altura = 1.72m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = santos.Id },

                    // Genéricos
                    new Jogador { Nome = "Carlos Matheus",     DataNascimento = new DateTime(1940,1,1), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 28, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Eduardo Martins",    DataNascimento = new DateTime(1940,2,1), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 29, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                    new Jogador { Nome = "Fábio Henrique",     DataNascimento = new DateTime(1940,3,1), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 30, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = santos.Id },
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var ajax = context.Times.FirstOrDefault(t => t.Nome == "Ajax 1995");
            if (ajax != null)
            {

                var comissaoTecnica = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Erik ten Hag", DataNascimento = new DateTime(1970, 2, 2), Cargo = Cargo.Treinador, TimeId = ajax.Id },
                    new ComissaoTecnica { Nome = "Alfred Schreuder", DataNascimento = new DateTime(1972, 11, 2), Cargo = Cargo.Auxiliar, TimeId = ajax.Id },
                    new ComissaoTecnica { Nome = "Carlo L'Ami", DataNascimento = new DateTime(1966, 6, 20), Cargo = Cargo.TreinadorGoleiros, TimeId = ajax.Id },
                    new ComissaoTecnica { Nome = "Sam Feringa", DataNascimento = new DateTime(1992, 5, 15), Cargo = Cargo.PreparadorFisico, TimeId = ajax.Id },
                    new ComissaoTecnica { Nome = "Frank van Deursen", DataNascimento = new DateTime(1985, 3, 10), Cargo = Cargo.Fisiologista, TimeId = ajax.Id },
                    new ComissaoTecnica { Nome = "Maarten Gozeling", DataNascimento = new DateTime(1980, 9, 5), Cargo = Cargo.Fisioterapeuta, TimeId = ajax.Id }
                };

                comissaoTecnica.ForEach(c => context.ComissaoTecnica.AddOrUpdate(p => new { p.Nome, p.Cargo }, c));
                context.SaveChanges();

                // 2. Prepara a lista de jogadores
                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Edwin van der Sar",  DataNascimento = new DateTime(1970, 10, 29), Nacionalidade = "Países Baixos", Posicao = Posicao.Goleiro,    NumeroCamisa = 1,  Altura = 1.98m, Peso = 89m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Fred Grim",          DataNascimento = new DateTime(1965, 8, 17),  Nacionalidade = "Países Baixos", Posicao = Posicao.Goleiro,    NumeroCamisa = 12, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },

                    // Laterais direitos
                    new Jogador { Nome = "Michael Reiziger",   DataNascimento = new DateTime(1973, 5, 3),   Nacionalidade = "Países Baixos", Posicao = Posicao.Lateral,   NumeroCamisa = 2,  Altura = 1.79m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },

                    // Zagueiros
                    new Jogador { Nome = "Danny Blind",        DataNascimento = new DateTime(1961, 8, 1),   Nacionalidade = "Países Baixos", Posicao = Posicao.Zagueiro,   NumeroCamisa = 3,  Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Winston Bogarde",    DataNascimento = new DateTime(1970, 10, 22), Nacionalidade = "Países Baixos", Posicao = Posicao.Zagueiro,   NumeroCamisa = 5,  Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "John van den Brom",  DataNascimento = new DateTime(1966, 10, 4),  Nacionalidade = "Países Baixos", Posicao = Posicao.Zagueiro,   NumeroCamisa = 6,  Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },

                    // Laterais esquerdos
                    new Jogador { Nome = "Frank de Boer",      DataNascimento = new DateTime(1970, 5, 15),  Nacionalidade = "Países Baixos", Posicao = Posicao.Lateral,   NumeroCamisa = 4,  Altura = 1.80m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = ajax.Id },
                    new Jogador { Nome = "Michel Kreek",       DataNascimento = new DateTime(1971, 1, 16),  Nacionalidade = "Países Baixos", Posicao = Posicao.Lateral,   NumeroCamisa = 15, Altura = 1.83m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },

                    // Volantes
                    new Jogador { Nome = "Frank Rijkaard",     DataNascimento = new DateTime(1962, 9, 30),  Nacionalidade = "Países Baixos", Posicao = Posicao.Volante,   NumeroCamisa = 8,  Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Edgar Davids",       DataNascimento = new DateTime(1973, 3, 13),  Nacionalidade = "Países Baixos", Posicao = Posicao.Volante,   NumeroCamisa = 13, Altura = 1.69m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },

                    // Meias
                    new Jogador { Nome = "Ronald de Boer",     DataNascimento = new DateTime(1970, 7, 15),  Nacionalidade = "Países Baixos", Posicao = Posicao.Meia,      NumeroCamisa = 7,  Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Clarence Seedorf",   DataNascimento = new DateTime(1976, 4, 1),   Nacionalidade = "Suriname",     Posicao = Posicao.Meia,      NumeroCamisa = 14, Altura = 1.77m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "George Finidi",       DataNascimento = new DateTime(1971, 4, 15),  Nacionalidade = "Nigéria",       Posicao = Posicao.Meia,      NumeroCamisa = 17, Altura = 1.89m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Tarik Oulida",       DataNascimento = new DateTime(1974, 1, 19),  Nacionalidade = "Países Baixos", Posicao = Posicao.Meia,      NumeroCamisa = 16, Altura = 1.76m, Peso = 71m, PePreferido = PePreferido.Esquerdo, TimeId = ajax.Id },

                    // Atacantes
                    new Jogador { Nome = "Patrick Kluivert",   DataNascimento = new DateTime(1976, 7, 1),   Nacionalidade = "Países Baixos", Posicao = Posicao.Atacante,  NumeroCamisa = 9,  Altura = 1.91m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Jari Litmanen",      DataNascimento = new DateTime(1971, 2, 20),  Nacionalidade = "Finlândia",     Posicao = Posicao.Atacante,  NumeroCamisa = 10, Altura = 1.81m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Marc Overmars",      DataNascimento = new DateTime(1973, 3, 29),  Nacionalidade = "Países Baixos", Posicao = Posicao.Atacante,  NumeroCamisa = 11, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Nwankwo Kanu",       DataNascimento = new DateTime(1976, 8, 1),   Nacionalidade = "Nigéria",       Posicao = Posicao.Atacante,  NumeroCamisa = 18, Altura = 1.97m, Peso = 82m, PePreferido = PePreferido.Esquerdo, TimeId = ajax.Id },
                    new Jogador { Nome = "Peter van Vossen",   DataNascimento = new DateTime(1968, 4, 21),  Nacionalidade = "Países Baixos", Posicao = Posicao.Atacante,  NumeroCamisa = 19, Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Nordin Wooter",      DataNascimento = new DateTime(1976, 11, 1), Nacionalidade = "Países Baixos", Posicao = Posicao.Atacante,  NumeroCamisa = 20, Altura = 1.69m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },


                    new Jogador { Nome = "Lucas Mendes", DataNascimento = new DateTime(1995, 3, 15),        Nacionalidade = "Brasil", Posicao = Posicao.Meia, NumeroCamisa = 91, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Anders Viklund", DataNascimento = new DateTime(1992, 11, 22),     Nacionalidade = "Suécia", Posicao = Posicao.Zagueiro, NumeroCamisa = 92, Altura = 1.94m, Peso = 86m, PePreferido = PePreferido.Esquerdo, TimeId = ajax.Id },
                    new Jogador { Nome = "Yusuke Tanaka", DataNascimento = new DateTime(1997, 5, 8),        Nacionalidade = "Japão", Posicao = Posicao.Lateral, NumeroCamisa = 93, Altura = 1.75m, Peso = 68m, PePreferido = PePreferido.Ambidestro, TimeId = ajax.Id },
                    new Jogador { Nome = "Ibrahim Diallo", DataNascimento = new DateTime(1990, 9, 30),      Nacionalidade = "Senegal", Posicao = Posicao.Volante, NumeroCamisa = 94, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Oliver Hart", DataNascimento = new DateTime(1989, 2, 14),         Nacionalidade = "Inglaterra", Posicao = Posicao.Goleiro, NumeroCamisa = 95, Altura = 1.92m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Dario Espinoza", DataNascimento = new DateTime(1994, 7, 25),      Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 96, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = ajax.Id },
                    new Jogador { Nome = "Nikola Jovanovic", DataNascimento = new DateTime(1993, 12, 5),    Nacionalidade = "Sérvia", Posicao = Posicao.Meia, NumeroCamisa = 97, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Moussa Diarra", DataNascimento = new DateTime(1996, 4, 18),       Nacionalidade = "Mali", Posicao = Posicao.Zagueiro, NumeroCamisa = 98, Altura = 1.89m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = ajax.Id },
                    new Jogador { Nome = "Viktor Petrenko", DataNascimento = new DateTime(1991, 8, 12),     Nacionalidade = "Ucrânia", Posicao = Posicao.Atacante, NumeroCamisa = 99, Altura = 1.77m, Peso = 71m, PePreferido = PePreferido.Esquerdo, TimeId = ajax.Id },
                    new Jogador { Nome = "Federico Costa", DataNascimento = new DateTime(1997, 6, 14),      Nacionalidade = "Itália", Posicao = Posicao.Meia, NumeroCamisa = 80, Altura = 1.82m, Peso = 77m, PePreferido = PePreferido.Esquerdo, TimeId = ajax.Id }
                };

                // 3. Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                // 4. Persiste tudo
                context.SaveChanges();
            }

            var corinthians = context.Times.FirstOrDefault(t => t.Nome == "Corinthians 2012");
            if (corinthians != null)
            {

                var comissaoTecnica = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Fábio Carille", DataNascimento = new DateTime(1973, 9, 26), Cargo = Cargo.Treinador, TimeId = corinthians.Id },
                    new ComissaoTecnica { Nome = "Emiliano Díaz", DataNascimento = new DateTime(1983, 8, 15), Cargo = Cargo.Auxiliar, TimeId = corinthians.Id },
                    new ComissaoTecnica { Nome = "Walmir Cruz", DataNascimento = new DateTime(1964, 5, 12), Cargo = Cargo.PreparadorFisico, TimeId = corinthians.Id },
                    new ComissaoTecnica { Nome = "Mauro da Silva", DataNascimento = new DateTime(1970, 3, 22), Cargo = Cargo.Fisiologista, TimeId = corinthians.Id },
                    new ComissaoTecnica { Nome = "Carlos L'Ami", DataNascimento = new DateTime(1966, 6, 20), Cargo = Cargo.TreinadorGoleiros, TimeId = corinthians.Id },
                    new ComissaoTecnica { Nome = "Bruno Mazziotti", DataNascimento = new DateTime(1978, 11, 5), Cargo = Cargo.Fisioterapeuta, TimeId = corinthians.Id }
                };

                comissaoTecnica.ForEach(c => context.ComissaoTecnica.AddOrUpdate(p => new { p.Nome, p.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Cássio",            DataNascimento = new DateTime(1987, 6, 6),   Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumeroCamisa = 12, Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Danilo Fernandes",  DataNascimento = new DateTime(1988, 4, 3),   Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumeroCamisa = 22, Altura = 1.89m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Júlio César",       DataNascimento = new DateTime(1984, 10, 27), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumeroCamisa = 1,  Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Matheus Vidotto",   DataNascimento = new DateTime(1993, 4, 10),  Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumeroCamisa = 32, Altura = 1.90m, Peso = 86m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Renan",             DataNascimento = new DateTime(1990, 12, 12), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro, NumeroCamisa = 99,  Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },

                    // Defensores
                    new Jogador { Nome = "Alessandro",        DataNascimento = new DateTime(1979, 1, 10),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 2,  Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Chicão",            DataNascimento = new DateTime(1981, 6, 3),   Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 3,  Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Fábio Santos",      DataNascimento = new DateTime(1985, 9, 16),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 6,  Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians.Id },
                    new Jogador { Nome = "Felipe Monteiro",   DataNascimento = new DateTime(1989, 5, 16),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 28, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Leandro Castán",    DataNascimento = new DateTime(1986, 11, 5),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 14, Altura = 1.86m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Paulo André",        DataNascimento = new DateTime(1983, 8, 20),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 13, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Dodô",              DataNascimento = new DateTime(1992, 2, 6),   Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 98,  Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians.Id },
                    new Jogador { Nome = "Guilherme Andrade", DataNascimento = new DateTime(1989, 1, 31),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 26, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Marquinhos",        DataNascimento = new DateTime(1994, 5, 14),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,NumeroCamisa = 28, Altura = 1.84m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Ramon Motta",       DataNascimento = new DateTime(1988, 5, 6),   Nacionalidade = "Brasil", Posicao = Posicao.Lateral, NumeroCamisa = 4,  Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians.Id },

                    // Meio-campistas
                    new Jogador { Nome = "Paulinho",          DataNascimento = new DateTime(1988, 7, 25),  Nacionalidade = "Brasil", Posicao = Posicao.Volante,NumeroCamisa = 8,  Altura = 1.85m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Ralf",              DataNascimento = new DateTime(1984, 6, 9),   Nacionalidade = "Brasil", Posicao = Posicao.Volante,NumeroCamisa = 5,  Altura = 1.80m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Douglas",           DataNascimento = new DateTime(1982, 2, 18),  Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Edenilson",         DataNascimento = new DateTime(1989, 12, 18), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 21, Altura = 1.72m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Alex",              DataNascimento = new DateTime(1982, 3, 25),  Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 12, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians.Id },
                    new Jogador { Nome = "Danilo",            DataNascimento = new DateTime(1979, 6, 11),  Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 20, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Luis Ramírez",      DataNascimento = new DateTime(1984, 11, 10), Nacionalidade = "Peru",   Posicao = Posicao.Meia,    NumeroCamisa = 97,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Willian Arão",      DataNascimento = new DateTime(1992, 3, 12),  Nacionalidade = "Brasil", Posicao = Posicao.Volante,NumeroCamisa = 17, Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },

                    // Atacantes
                    new Jogador { Nome = "Emerson Sheik",     DataNascimento = new DateTime(1978, 12, 6),  Nacionalidade = "Qatar",  Posicao = Posicao.Atacante,NumeroCamisa = 11, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Jorge Henrique",    DataNascimento = new DateTime(1982, 4, 23),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 23, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Romarinho",         DataNascimento = new DateTime(1990, 12, 12), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 31, Altura = 1.76m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Liédson",           DataNascimento = new DateTime(1977, 12, 17), Nacionalidade = "Portugal",Posicao = Posicao.Atacante,NumeroCamisa = 96,  Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians.Id },
                    new Jogador { Nome = "Willian",           DataNascimento = new DateTime(1986, 11, 19), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 95,  Altura = 1.75m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = corinthians.Id },
                    new Jogador { Nome = "Élton",             DataNascimento = new DateTime(1985, 8, 1),   Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 94,  Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id },
                    new Jogador { Nome = "Gilsinho",          DataNascimento = new DateTime(1984, 4, 4),   Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 93,  Altura = 1.77m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = corinthians.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var saoPaulo = context.Times.FirstOrDefault(t => t.Nome == "São Paulo 2005");
            if (saoPaulo != null)
            {

                var comissaoTecnica = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Fernando Diniz", DataNascimento = new DateTime(1974, 3, 27), Cargo = Cargo.Treinador, TimeId = saoPaulo.Id },
                    new ComissaoTecnica { Nome = "Márcio Araújo", DataNascimento = new DateTime(1960, 5, 11), Cargo = Cargo.Auxiliar, TimeId = saoPaulo.Id },
                    new ComissaoTecnica { Nome = "Pedro Campos", DataNascimento = new DateTime(1985, 8, 20), Cargo = Cargo.PreparadorFisico, TimeId = saoPaulo.Id },
                    new ComissaoTecnica { Nome = "Luis Fernando de Barros", DataNascimento = new DateTime(1970, 2, 15), Cargo = Cargo.Fisiologista, TimeId = saoPaulo.Id },
                    new ComissaoTecnica { Nome = "Octávio Ohl", DataNascimento = new DateTime(1975, 9, 10), Cargo = Cargo.TreinadorGoleiros, TimeId = saoPaulo.Id },
                    new ComissaoTecnica { Nome = "Felipe Marques", DataNascimento = new DateTime(1980, 12, 5), Cargo = Cargo.Fisioterapeuta, TimeId = saoPaulo.Id }
                };

                comissaoTecnica.ForEach(c => context.ComissaoTecnica.AddOrUpdate(p => new { p.Nome, p.Cargo }, c));
                context.SaveChanges();

                // Obs.: Datas de nascimento, altura, peso e pé preferido são aproximados e podem ser ajustados.
                var jogadores = new List<Jogador>
                {
                    // — Elenco Mundial de Clubes (1–23)
                    new Jogador { Nome = "Rogério Ceni",       DataNascimento = new DateTime(1973, 1, 22), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Cicinho",            DataNascimento = new DateTime(1980, 6, 24), Nacionalidade = "Brasil", Posicao = Posicao.Lateral,  NumeroCamisa = 2,  Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Fabão",              DataNascimento = new DateTime(1976, 6, 15), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 3,  Altura = 1.87m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Edcarlos",           DataNascimento = new DateTime(1985, 5, 10), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 4,  Altura = 1.82m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Diego Lugano",       DataNascimento = new DateTime(1980, 11, 2), Nacionalidade = "Uruguai",Posicao = Posicao.Zagueiro, NumeroCamisa = 5,  Altura = 1.88m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Júnior",             DataNascimento = new DateTime(1979, 3, 26), Nacionalidade = "Brasil", Posicao = Posicao.Lateral,  NumeroCamisa = 6,  Altura = 1.70m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Mineiro",            DataNascimento = new DateTime(1975, 6, 2),  Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 7,  Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Josué",              DataNascimento = new DateTime(1979, 1, 29), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 8,  Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Grafite",            DataNascimento = new DateTime(1979, 6, 2),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.90m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Danilo",             DataNascimento = new DateTime(1980, 2, 22), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Márcio Amoroso",     DataNascimento = new DateTime(1974, 7, 5),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 11, Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Christian",          DataNascimento = new DateTime(1975, 6, 12), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 12, Altura = 1.75m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Alex Bruno",         DataNascimento = new DateTime(1982, 5, 9),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 13, Altura = 1.89m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Aloísio Chulapa",    DataNascimento = new DateTime(1975, 10, 22),Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 14, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Denílson",           DataNascimento = new DateTime(1977, 2, 24), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 15, Altura = 1.84m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Fábio Santos",       DataNascimento = new DateTime(1984, 9, 16), Nacionalidade = "Brasil", Posicao = Posicao.Lateral,  NumeroCamisa = 16, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Esquerdo, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Renan",              DataNascimento = new DateTime(1985, 3, 29), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 17, Altura = 1.81m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Flávio Donizete",    DataNascimento = new DateTime(1984, 1, 16), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 18, Altura = 1.83m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Thiago Ribeiro",     DataNascimento = new DateTime(1986, 1, 4),  Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 19, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Richarlyson",        DataNascimento = new DateTime(1982, 12, 22),Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 20, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Souza",              DataNascimento = new DateTime(1975, 6, 15), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 21, Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Bosco",              DataNascimento = new DateTime(1974, 11, 14),Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 22, Altura = 1.84m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Flávio Kretzer",     DataNascimento = new DateTime(1974, 11, 14),Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 23, Altura = 1.84m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },

                    // — Goleiros adicionais (24–25)
                    new Jogador { Nome = "Bruno",              DataNascimento = new DateTime(1984, 6, 17), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 24, Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Mateus",             DataNascimento = new DateTime(1986, 3, 26), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,  NumeroCamisa = 25, Altura = 1.90m, Peso = 86m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },

                    // — Defensor adicional (26)
                    new Jogador { Nome = "Rodrigo",            DataNascimento = new DateTime(1980, 1, 1), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 26, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },

                    // — Meio-campistas adicionais (27–28)
                    new Jogador { Nome = "Davi",               DataNascimento = new DateTime(1981, 4, 11),Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 27, Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Hernanes",           DataNascimento = new DateTime(1985, 6, 29),Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 28, Altura = 1.82m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },

                    // — Atacantes adicionais (29–30)
                    new Jogador { Nome = "Luizão",             DataNascimento = new DateTime(1975, 11, 14),Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 29, Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id },
                    new Jogador { Nome = "Daniel Rossi",       DataNascimento = new DateTime(1980, 1, 1), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 30, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = saoPaulo.Id }
                };

                // Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var chelsea = context.Times.FirstOrDefault(t => t.Nome == "Chelsea 2012");
            if (chelsea != null)
            {

                var comissaoTecnica = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Frank Lampard", DataNascimento = new DateTime(1978, 6, 20), Cargo = Cargo.Treinador, TimeId = chelsea.Id },
                    new ComissaoTecnica { Nome = "Jody Morris", DataNascimento = new DateTime(1978, 12, 22), Cargo = Cargo.Auxiliar, TimeId = chelsea.Id },
                    new ComissaoTecnica { Nome = "Chris Jones", DataNascimento = new DateTime(1970, 4, 15), Cargo = Cargo.PreparadorFisico, TimeId = chelsea.Id },
                    new ComissaoTecnica { Nome = "Henrique Hilário", DataNascimento = new DateTime(1975, 10, 21), Cargo = Cargo.TreinadorGoleiros, TimeId = chelsea.Id },
                    new ComissaoTecnica { Nome = "James Russell", DataNascimento = new DateTime(1987, 3, 10), Cargo = Cargo.Fisiologista, TimeId = chelsea.Id },
                    new ComissaoTecnica { Nome = "Michael Smith", DataNascimento = new DateTime(1980, 5, 5), Cargo = Cargo.Fisioterapeuta, TimeId = chelsea.Id }
                };

                comissaoTecnica.ForEach(c => context.ComissaoTecnica.AddOrUpdate(p => new { p.Nome, p.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Petr Čech",        DataNascimento = new DateTime(1982, 5, 20),  Nacionalidade = "República Checa", Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.96m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Ross Turnbull",    DataNascimento = new DateTime(1985, 1, 4),   Nacionalidade = "Inglaterra",       Posicao = Posicao.Goleiro,  NumeroCamisa = 22, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Henrique Hilário", DataNascimento = new DateTime(1975, 10, 7), Nacionalidade = "Portugal",         Posicao = Posicao.Goleiro,  NumeroCamisa = 40, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Jamal Blackman",   DataNascimento = new DateTime(1993, 10, 27),Nacionalidade = "Inglaterra",       Posicao = Posicao.Goleiro,  NumeroCamisa = 46, Altura = 1.96m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },

                    // Defensores
                    new Jogador { Nome = "Branislav Ivanović", DataNascimento = new DateTime(1984, 2, 22), Nacionalidade = "Sérvia",          Posicao = Posicao.Zagueiro, NumeroCamisa = 2,  Altura = 1.84m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Ashley Cole",        DataNascimento = new DateTime(1980, 12, 20),Nacionalidade = "Inglaterra",       Posicao = Posicao.Lateral,  NumeroCamisa = 3,  Altura = 1.71m, Peso = 68m, PePreferido = PePreferido.Esquerdo, TimeId = chelsea.Id },
                    new Jogador { Nome = "David Luiz",         DataNascimento = new DateTime(1987, 4, 22), Nacionalidade = "Brasil",           Posicao = Posicao.Zagueiro, NumeroCamisa = 4,  Altura = 1.89m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "José Bosingwa",      DataNascimento = new DateTime(1982, 8, 24), Nacionalidade = "Portugal",         Posicao = Posicao.Lateral,  NumeroCamisa = 17, Altura = 1.80m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Paulo Ferreira",     DataNascimento = new DateTime(1979, 1, 18), Nacionalidade = "Portugal",         Posicao = Posicao.Zagueiro, NumeroCamisa = 19, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Gary Cahill",        DataNascimento = new DateTime(1985, 12, 19),Nacionalidade = "Inglaterra",       Posicao = Posicao.Zagueiro, NumeroCamisa = 24, Altura = 1.93m, Peso = 86m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "John Terry",         DataNascimento = new DateTime(1980, 12, 7), Nacionalidade = "Inglaterra",       Posicao = Posicao.Zagueiro, NumeroCamisa = 26, Altura = 1.87m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Sam Hutchinson",     DataNascimento = new DateTime(1989, 5, 3),  Nacionalidade = "Inglaterra",       Posicao = Posicao.Zagueiro, NumeroCamisa = 27, Altura = 1.88m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Ryan Bertrand",      DataNascimento = new DateTime(1989, 8, 5),  Nacionalidade = "Inglaterra",       Posicao = Posicao.Lateral,  NumeroCamisa = 34, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Esquerdo, TimeId = chelsea.Id },
                    new Jogador { Nome = "Nathaniel Chalobah", DataNascimento = new DateTime(1994, 12, 12),Nacionalidade = "Inglaterra",       Posicao = Posicao.Zagueiro, NumeroCamisa = 45, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Michael Essien",     DataNascimento = new DateTime(1982, 12, 3), Nacionalidade = "Gana",             Posicao = Posicao.Meia,    NumeroCamisa = 5,  Altura = 1.78m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Oriol Romeu",        DataNascimento = new DateTime(1991, 9, 24), Nacionalidade = "Espanha",          Posicao = Posicao.Volante, NumeroCamisa = 6,  Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Ramires",            DataNascimento = new DateTime(1987, 3, 24), Nacionalidade = "Brasil",           Posicao = Posicao.Meia,    NumeroCamisa = 7,  Altura = 1.72m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Frank Lampard",      DataNascimento = new DateTime(1978, 6, 20), Nacionalidade = "Inglaterra",       Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.84m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Juan Mata",          DataNascimento = new DateTime(1988, 4, 23), Nacionalidade = "Espanha",          Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Mikel John Obi",     DataNascimento = new DateTime(1987, 4, 22), Nacionalidade = "Nigéria",          Posicao = Posicao.Volante, NumeroCamisa = 12, Altura = 1.83m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Florent Malouda",    DataNascimento = new DateTime(1980, 6, 13), Nacionalidade = "França",           Posicao = Posicao.Meia,    NumeroCamisa = 15, Altura = 1.72m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Raul Meireles",      DataNascimento = new DateTime(1983, 3, 17), Nacionalidade = "Portugal",         Posicao = Posicao.Meia,    NumeroCamisa = 16, Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Josh McEachran",     DataNascimento = new DateTime(1993, 3, 1),  Nacionalidade = "Inglaterra",       Posicao = Posicao.Meia,    NumeroCamisa = 20, Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Lucas Piazon",       DataNascimento = new DateTime(1994, 1, 20), Nacionalidade = "Brasil",           Posicao = Posicao.Meia,    NumeroCamisa = 35, Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },

                    // Atacantes
                    new Jogador { Nome = "Fernando Torres",    DataNascimento = new DateTime(1984, 3, 20), Nacionalidade = "Espanha",          Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.86m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Didier Drogba",      DataNascimento = new DateTime(1978, 3, 11), Nacionalidade = "Costa do Marfim",   Posicao = Posicao.Atacante,NumeroCamisa = 11, Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Romelu Lukaku",      DataNascimento = new DateTime(1993, 5, 13), Nacionalidade = "Bélgica",          Posicao = Posicao.Atacante,NumeroCamisa = 18, Altura = 1.90m, Peso = 86m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Salomon Kalou",      DataNascimento = new DateTime(1985, 8, 5),  Nacionalidade = "Costa do Marfim",   Posicao = Posicao.Atacante,NumeroCamisa = 21, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },
                    new Jogador { Nome = "Daniel Sturridge",   DataNascimento = new DateTime(1989, 9, 1),  Nacionalidade = "Inglaterra",       Posicao = Posicao.Atacante,NumeroCamisa = 23, Altura = 1.78m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id },

                    // Fictício
                    new Jogador { Nome = "Alex Turner",        DataNascimento = new DateTime(1990, 1, 1),  Nacionalidade = "Inglaterra",       Posicao = Posicao.Meia,    NumeroCamisa = 50, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = chelsea.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var inter = context.Times.FirstOrDefault(t => t.Nome == "Inter Milan 2010");
            if (inter != null)
            {

                var comissaoTecnica = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Zé Ricardo", DataNascimento = new DateTime(1971, 6, 5), Cargo = Cargo.Treinador, TimeId = inter.Id },
                    new ComissaoTecnica { Nome = "Cléber dos Santos", DataNascimento = new DateTime(1975, 3, 10), Cargo = Cargo.Auxiliar, TimeId = inter.Id },
                    new ComissaoTecnica { Nome = "Marcus Vinicius Nobre", DataNascimento = new DateTime(1980, 5, 15), Cargo = Cargo.PreparadorFisico, TimeId = inter.Id },
                    new ComissaoTecnica { Nome = "Daniel Schneider", DataNascimento = new DateTime(1965, 8, 20), Cargo = Cargo.TreinadorGoleiros, TimeId = inter.Id },
                    new ComissaoTecnica { Nome = "Tadashi Hara", DataNascimento = new DateTime(1985, 4, 10), Cargo = Cargo.Fisiologista, TimeId = inter.Id },
                    new ComissaoTecnica { Nome = "Gabriel Pizetta", DataNascimento = new DateTime(1990, 7, 25), Cargo = Cargo.Fisioterapeuta, TimeId = inter.Id }
                };

                comissaoTecnica.ForEach(c => context.ComissaoTecnica.AddOrUpdate(p => new { p.Nome, p.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Francesco Toldo",   DataNascimento = new DateTime(1971,12,02), Nacionalidade = "Itália",          Posicao = Posicao.Goleiro, NumeroCamisa = 1,  Altura = 1.95m, Peso = 88m, PePreferido = PePreferido.Esquerdo, TimeId = inter.Id },
                    new Jogador { Nome = "Júlio César",       DataNascimento = new DateTime(1979, 9, 3), Nacionalidade = "Brasil",          Posicao = Posicao.Goleiro, NumeroCamisa = 12, Altura = 1.87m, Peso = 80m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Paolo Orlandoni",   DataNascimento = new DateTime(1972, 8,12), Nacionalidade = "Itália",          Posicao = Posicao.Goleiro, NumeroCamisa = 21, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Vid Belec",         DataNascimento = new DateTime(1990, 6, 6), Nacionalidade = "Eslovênia",       Posicao = Posicao.Goleiro, NumeroCamisa = 51, Altura = 1.90m, Peso = 84m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },

                    // Defensores
                    new Jogador { Nome = "Cristian Chivu",    DataNascimento = new DateTime(1980,10,26), Nacionalidade = "Romênia",         Posicao = Posicao.Zagueiro,NumeroCamisa = 26, Altura = 1.80m, Peso = 78m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Iván Córdoba",      DataNascimento = new DateTime(1976, 8,11), Nacionalidade = "Colômbia",        Posicao = Posicao.Zagueiro,NumeroCamisa = 2,  Altura = 1.75m, Peso = 67m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Giulio Donati",     DataNascimento = new DateTime(1990, 2, 5), Nacionalidade = "Itália",          Posicao = Posicao.Lateral, NumeroCamisa = 29, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Lúcio",             DataNascimento = new DateTime(1978, 5, 8), Nacionalidade = "Brasil",          Posicao = Posicao.Zagueiro,NumeroCamisa = 6,  Altura = 1.88m, Peso = 90m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Maicon",            DataNascimento = new DateTime(1981, 7,26), Nacionalidade = "Brasil",          Posicao = Posicao.Lateral, NumeroCamisa = 13, Altura = 1.81m, Peso = 78m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Lorenzo Crisetig",  DataNascimento = new DateTime(1993, 1,20), Nacionalidade = "Itália",          Posicao = Posicao.Meia,    NumeroCamisa = 48, Altura = 1.80m, Peso = 72m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "René Krhin",         DataNascimento = new DateTime(1990, 5,21), Nacionalidade = "Eslovênia",       Posicao = Posicao.Meia,    NumeroCamisa = 15, Altura = 1.84m, Peso = 75m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "MacDonald Mariga",   DataNascimento = new DateTime(1987, 4, 4), Nacionalidade = "Quênia",          Posicao = Posicao.Volante, NumeroCamisa = 17, Altura = 1.85m, Peso = 78m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Sulley Muntari",     DataNascimento = new DateTime(1984, 8,27), Nacionalidade = "Gana",            Posicao = Posicao.Volante, NumeroCamisa = 11, Altura = 1.79m, Peso = 78m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Wesley Sneijder",    DataNascimento = new DateTime(1984, 6, 9), Nacionalidade = "Países Baixos",   Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.70m, Peso = 70m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Dejan Stanković",    DataNascimento = new DateTime(1978, 9,11), Nacionalidade = "Sérvia",          Posicao = Posicao.Meia,    NumeroCamisa = 5,  Altura = 1.81m, Peso = 78m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Alen Stevanović",    DataNascimento = new DateTime(1991, 1, 7), Nacionalidade = "Sérvia",          Posicao = Posicao.Meia,    NumeroCamisa = 28, Altura = 1.80m, Peso = 72m, PePreferido = PePreferido.Esquerdo,TimeId = inter.Id },
                    new Jogador { Nome = "Thiago Motta",       DataNascimento = new DateTime(1982, 8,28), Nacionalidade = "Itália",          Posicao = Posicao.Volante, NumeroCamisa = 8,  Altura = 1.83m, Peso = 76m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },

                    // Atacantes
                    new Jogador { Nome = "Marko Arnautović",   DataNascimento = new DateTime(1989, 4,19), Nacionalidade = "Áustria",         Posicao = Posicao.Atacante,NumeroCamisa = 89, Altura = 1.85m, Peso = 78m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Mario Balotelli",    DataNascimento = new DateTime(1990, 8,12), Nacionalidade = "Itália",          Posicao = Posicao.Atacante,NumeroCamisa = 45, Altura = 1.89m, Peso = 82m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Mattia Destro",      DataNascimento = new DateTime(1991, 3,20), Nacionalidade = "Itália",          Posicao = Posicao.Atacante,NumeroCamisa = 49, Altura = 1.82m, Peso = 76m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Samuel Eto'o",       DataNascimento = new DateTime(1981, 3,10), Nacionalidade = "Camarões",        Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Diego Milito",       DataNascimento = new DateTime(1979, 6,12), Nacionalidade = "Argentina",       Posicao = Posicao.Atacante,NumeroCamisa = 22, Altura = 1.77m, Peso = 74m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Goran Pandev",       DataNascimento = new DateTime(1983, 7,27), Nacionalidade = "Macedônia",       Posicao = Posicao.Atacante,NumeroCamisa = 27, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Ricardo Quaresma",   DataNascimento = new DateTime(1983, 9,26), Nacionalidade = "Portugal",        Posicao = Posicao.Atacante,NumeroCamisa = 7,  Altura = 1.70m, Peso = 65m, PePreferido = PePreferido.Esquerdo,TimeId = inter.Id },

                    // Jogadores Fictícios para completar 30
                    new Jogador { Nome = "Matteo Rossi",       DataNascimento = new DateTime(1990, 2,10), Nacionalidade = "Itália",          Posicao = Posicao.Meia,    NumeroCamisa = 30, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Luca Bianchi",       DataNascimento = new DateTime(1991, 5,15), Nacionalidade = "Itália",          Posicao = Posicao.Zagueiro,NumeroCamisa = 31, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Alessandro Gallo",   DataNascimento = new DateTime(1992, 7,20), Nacionalidade = "Itália",          Posicao = Posicao.Atacante,NumeroCamisa = 32, Altura = 1.83m, Peso = 77m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Davide Conti",       DataNascimento = new DateTime(1990, 9, 1), Nacionalidade = "Itália",          Posicao = Posicao.Volante, NumeroCamisa = 33, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Esquerdo,TimeId = inter.Id },
                    new Jogador { Nome = "Marco Ricci",        DataNascimento = new DateTime(1989,12,12), Nacionalidade = "Itália",          Posicao = Posicao.Meia,    NumeroCamisa = 34, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito,  TimeId = inter.Id },
                    new Jogador { Nome = "Antonio Lombardi",   DataNascimento = new DateTime(1991, 3,25), Nacionalidade = "Itália",          Posicao = Posicao.Lateral, NumeroCamisa = 35, Altura = 1.86m, Peso = 82m, PePreferido = PePreferido.Direito,  TimeId = inter.Id }
                };

                // Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var boca2003 = context.Times.FirstOrDefault(t => t.Nome == "Boca Juniors 2003");
            if (boca2003 != null)
            {

                var comissaoTecnica = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Carlos Bianchi", DataNascimento = new DateTime(1949, 4, 26), Cargo = Cargo.Treinador, TimeId = boca2003.Id },
                    new ComissaoTecnica { Nome = "Roberto Abbondanzieri", DataNascimento = new DateTime(1972, 8, 19), Cargo = Cargo.TreinadorGoleiros, TimeId = boca2003.Id },
                    new ComissaoTecnica { Nome = "Héctor Enrique", DataNascimento = new DateTime(1963, 7, 17), Cargo = Cargo.Auxiliar, TimeId = boca2003.Id },
                    new ComissaoTecnica { Nome = "José Luis Rodríguez", DataNascimento = new DateTime(1963, 11, 18), Cargo = Cargo.PreparadorFisico, TimeId = boca2003.Id },
                    new ComissaoTecnica { Nome = "Carlos Bilardo", DataNascimento = new DateTime(1939, 3, 16), Cargo = Cargo.Fisiologista, TimeId = boca2003.Id },
                    new ComissaoTecnica { Nome = "Alejandro Manzoni", DataNascimento = new DateTime(1970, 5, 5), Cargo = Cargo.Fisioterapeuta, TimeId = boca2003.Id }
                };

                comissaoTecnica.ForEach(c => context.ComissaoTecnica.AddOrUpdate(p => new { p.Nome, p.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Roberto Abbondanzieri",    DataNascimento = new DateTime(1972, 8, 19), Nacionalidade = "Argentina", Posicao = Posicao.Goleiro,  NumeroCamisa = 1,  Altura = 1.86m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Willy Caballero",          DataNascimento = new DateTime(1981, 9, 28), Nacionalidade = "Argentina", Posicao = Posicao.Goleiro,  NumeroCamisa = 12, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Cristian Muñoz",           DataNascimento = new DateTime(1977, 7,  1), Nacionalidade = "Argentina", Posicao = Posicao.Goleiro,  NumeroCamisa = 25, Altura = 1.90m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Gustavo Eberto",           DataNascimento = new DateTime(1983, 8, 30), Nacionalidade = "Argentina", Posicao = Posicao.Goleiro,  NumeroCamisa = 31, Altura = 1.91m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },

                    // Defensores
                    new Jogador { Nome = "Rolando Schiavi",          DataNascimento = new DateTime(1973, 1, 18), Nacionalidade = "Argentina", Posicao = Posicao.Zagueiro, NumeroCamisa = 2,  Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Clemente Rodríguez",       DataNascimento = new DateTime(1981, 7, 31), Nacionalidade = "Argentina", Posicao = Posicao.Lateral,  NumeroCamisa = 3,  Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = boca2003.Id },
                    new Jogador { Nome = "Hugo Ibarra",              DataNascimento = new DateTime(1974, 4,  1), Nacionalidade = "Argentina", Posicao = Posicao.Lateral,  NumeroCamisa = 4,  Altura = 1.70m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Nicolás Burdisso",         DataNascimento = new DateTime(1981, 4, 12), Nacionalidade = "Argentina", Posicao = Posicao.Zagueiro, NumeroCamisa = 6,  Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "José María Calvo",         DataNascimento = new DateTime(1981, 7, 15), Nacionalidade = "Argentina", Posicao = Posicao.Zagueiro, NumeroCamisa = 15, Altura = 1.82m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Diego Sebastián Crosa",    DataNascimento = new DateTime(1976, 4, 18), Nacionalidade = "Argentina", Posicao = Posicao.Zagueiro, NumeroCamisa = 13, Altura = 1.80m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Joel Barbosa",             DataNascimento = new DateTime(1983, 1, 15), Nacionalidade = "Argentina", Posicao = Posicao.Zagueiro, NumeroCamisa = 27, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Federico Carballo",        DataNascimento = new DateTime(1980, 3, 14), Nacionalidade = "Argentina", Posicao = Posicao.Lateral,  NumeroCamisa = 30, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Matías Silvestre",         DataNascimento = new DateTime(1984, 9, 25), Nacionalidade = "Argentina", Posicao = Posicao.Zagueiro, NumeroCamisa = 23, Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "César González",           DataNascimento = new DateTime(1982, 1, 25), Nacionalidade = "Argentina", Posicao = Posicao.Lateral,  NumeroCamisa = 28, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Sebastián Battaglia",     DataNascimento = new DateTime(1980,11,  8), Nacionalidade = "Argentina", Posicao = Posicao.Volante, NumeroCamisa = 5,  Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Diego Cagna",              DataNascimento = new DateTime(1970, 4, 19), Nacionalidade = "Argentina", Posicao = Posicao.Volante, NumeroCamisa = 8,  Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Alfredo Cascini",         DataNascimento = new DateTime(1971, 4,  7), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 22, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Matías Donnet",           DataNascimento = new DateTime(1980, 4, 18), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 18, Altura = 1.79m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Pablo Ledesma",           DataNascimento = new DateTime(1984, 2,  4), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 14, Altura = 1.68m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Miguel Caneo",            DataNascimento = new DateTime(1983, 3, 17), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 24, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Gabriel Christovao",      DataNascimento = new DateTime(1982, 2, 11), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 26, Altura = 1.84m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Javier Villarreal",       DataNascimento = new DateTime(1979, 3,  1), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 20, Altura = 1.75m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Omar Pérez",             DataNascimento = new DateTime(1981, 3, 29), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 11, Altura = 1.70m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Gustavo Pinto",          DataNascimento = new DateTime(1979, 5, 29), Nacionalidade = "Argentina", Posicao = Posicao.Meia,    NumeroCamisa = 29, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },

                    // Atacantes
                    new Jogador { Nome = "Guillermo Barros Schelotto", DataNascimento = new DateTime(1973, 5,  4), Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 7,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Ezequiel González",       DataNascimento = new DateTime(1980, 7, 10), Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 10, Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Marcelo Delgado",         DataNascimento = new DateTime(1973, 3, 24), Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 16, Altura = 1.74m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Raúl Estévez",            DataNascimento = new DateTime(1978, 1, 21), Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 17, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Franco Cángele",          DataNascimento = new DateTime(1984, 7, 16), Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 21, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id },
                    new Jogador { Nome = "Carlos Tévez",            DataNascimento = new DateTime(1984, 2,  5), Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 19, Altura = 1.71m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = boca2003.Id }
                };

                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var juventus = context.Times.FirstOrDefault(t => t.Nome == "Juventus 1985");
            if (juventus != null)
            {

                var comissaoTecnica = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Marcello Lippi", DataNascimento = new DateTime(1948, 4, 11), Cargo = Cargo.Treinador, TimeId = juventus.Id },
                    new ComissaoTecnica { Nome = "Roberto Sassi", DataNascimento = new DateTime(1960, 5, 5), Cargo = Cargo.Auxiliar, TimeId = juventus.Id },
                    new ComissaoTecnica { Nome = "Stefano Tavelli", DataNascimento = new DateTime(1965, 2, 20), Cargo = Cargo.PreparadorFisico, TimeId = juventus.Id },
                    new ComissaoTecnica { Nome = "Giovanni Mauri", DataNascimento = new DateTime(1962, 3, 15), Cargo = Cargo.Fisiologista, TimeId = juventus.Id },
                    new ComissaoTecnica { Nome = "Claudio Sassi", DataNascimento = new DateTime(1967, 7, 8), Cargo = Cargo.Fisioterapeuta, TimeId = juventus.Id }
                };

                comissaoTecnica.ForEach(c => context.ComissaoTecnica.AddOrUpdate(p => new { p.Nome, p.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Stefano Tacconi",     DataNascimento = new DateTime(1957, 5, 13), Nacionalidade = "Itália",           Posicao = Posicao.Goleiro, NumeroCamisa = 1,  Altura = 1.92m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Luciano Bodini",      DataNascimento = new DateTime(1954, 2, 12), Nacionalidade = "Itália",           Posicao = Posicao.Goleiro, NumeroCamisa = 12, Altura = 1.84m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Giuliano Giuliani",   DataNascimento = new DateTime(1950, 6, 1),  Nacionalidade = "Itália",           Posicao = Posicao.Goleiro, NumeroCamisa = 22, Altura = 1.90m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },

                    // Defensores
                    new Jogador { Nome = "Gaetano Scirea",      DataNascimento = new DateTime(1953, 5, 25), Nacionalidade = "Itália",           Posicao = Posicao.Zagueiro,NumeroCamisa = 6,  Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Antonio Cabrini",     DataNascimento = new DateTime(1957, 10, 8), Nacionalidade = "Itália",           Posicao = Posicao.Lateral,  NumeroCamisa = 3,  Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = juventus.Id },
                    new Jogador { Nome = "Sergio Brio",         DataNascimento = new DateTime(1956, 8, 19), Nacionalidade = "Itália",           Posicao = Posicao.Zagueiro,NumeroCamisa = 2,  Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Luciano Favero",      DataNascimento = new DateTime(1957, 10, 11),Nacionalidade = "Itália",           Posicao = Posicao.Zagueiro,NumeroCamisa = 5,  Altura = 1.77m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Nicola Caricola",     DataNascimento = new DateTime(1963, 2, 13), Nacionalidade = "Itália",           Posicao = Posicao.Zagueiro,NumeroCamisa = 4,  Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Stefano Pioli",       DataNascimento = new DateTime(1965, 10, 20),Nacionalidade = "Itália",           Posicao = Posicao.Zagueiro,NumeroCamisa = 28, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Marco Tardelli",      DataNascimento = new DateTime(1954, 9, 24), Nacionalidade = "Itália",           Posicao = Posicao.Volante, NumeroCamisa = 7,  Altura = 1.77m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Beniamino Vignola",   DataNascimento = new DateTime(1959, 6, 12), Nacionalidade = "Itália",           Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.72m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Cesare Prandelli",    DataNascimento = new DateTime(1957, 8, 19), Nacionalidade = "Itália",           Posicao = Posicao.Volante, NumeroCamisa = 16, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Bruno Limido",        DataNascimento = new DateTime(1961, 3, 7),  Nacionalidade = "Itália",           Posicao = Posicao.Meia,    NumeroCamisa = 14, Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Aldo Dolcetti",       DataNascimento = new DateTime(1966,10,23),  Nacionalidade = "Itália",           Posicao = Posicao.Meia,    NumeroCamisa = 18, Altura = 1.71m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Giovanni Koetting",   DataNascimento = new DateTime(1962, 3,10),  Nacionalidade = "Itália",           Posicao = Posicao.Meia,    NumeroCamisa = 20, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Lionello Manfredonia",DataNascimento = new DateTime(1956,11,27),  Nacionalidade = "Itália",           Posicao = Posicao.Volante, NumeroCamisa = 21, Altura = 1.82m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },

                    // Atacantes
                    new Jogador { Nome = "Massimo Briaschi",   DataNascimento = new DateTime(1958, 5,12),  Nacionalidade = "Itália",           Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = juventus.Id },
                    new Jogador { Nome = "Paolo Rossi",        DataNascimento = new DateTime(1956, 9,23),  Nacionalidade = "Itália",           Posicao = Posicao.Atacante,NumeroCamisa = 10, Altura = 1.77m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Michael Laudrup",    DataNascimento = new DateTime(1964, 6,15),  Nacionalidade = "Dinamarca",        Posicao = Posicao.Meia,    NumeroCamisa = 11, Altura = 1.81m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Michel Platini",     DataNascimento = new DateTime(1955, 6,21),  Nacionalidade = "França",           Posicao = Posicao.Meia,    NumeroCamisa = 12, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Zbigniew Boniek",    DataNascimento = new DateTime(1956, 3, 3),  Nacionalidade = "Polônia",          Posicao = Posicao.Meia,    NumeroCamisa = 13, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Marco Pacione",      DataNascimento = new DateTime(1963, 7,27),  Nacionalidade = "Itália",           Posicao = Posicao.Atacante,NumeroCamisa = 15, Altura = 1.87m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
            
                    // Jogadores fictícios (40–42)
                    new Jogador { Nome = "Lorenzo Rossi",      DataNascimento = new DateTime(1965, 4, 1),  Nacionalidade = "Itália",           Posicao = Posicao.Meia,    NumeroCamisa = 40, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Carlos Alberto Silva", DataNascimento = new DateTime(1990, 1, 1), Nacionalidade = "Brasil",          Posicao = Posicao.Atacante, NumeroCamisa = 98, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Giovanni Esposito",  DataNascimento = new DateTime(1966, 8,22),  Nacionalidade = "Itália",           Posicao = Posicao.Zagueiro,NumeroCamisa = 41, Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Marco Allegri",      DataNascimento = new DateTime(1964, 5,16),  Nacionalidade = "Itália",           Posicao = Posicao.Lateral, NumeroCamisa = 42, Altura = 1.77m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = juventus.Id },
                    new Jogador { Nome = "Alessandro Bianchi", DataNascimento = new DateTime(1995, 3, 12), Nacionalidade = "Itália",           Posicao = Posicao.Goleiro, NumeroCamisa = 55, Altura = 1.92m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Ricardo Santos",     DataNascimento = new DateTime(1993, 7, 25), Nacionalidade = "Portugal",         Posicao = Posicao.Meia, NumeroCamisa = 56, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Matteo Ferrari",     DataNascimento = new DateTime(1998, 11, 5), Nacionalidade = "Itália",           Posicao = Posicao.Atacante, NumeroCamisa = 57, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Esquerdo, TimeId = juventus.Id },
                    new Jogador { Nome = "Davide Romano",      DataNascimento = new DateTime(1991, 2, 18), Nacionalidade = "Itália",           Posicao = Posicao.Zagueiro, NumeroCamisa = 58, Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = juventus.Id },
                    new Jogador { Nome = "Luka Kovac",         DataNascimento = new DateTime(1996, 9, 30), Nacionalidade = "Croácia",          Posicao = Posicao.Lateral, NumeroCamisa = 59, Altura = 1.81m, Peso = 76m, PePreferido = PePreferido.Ambidestro, TimeId = juventus.Id }
                };

                // Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var palmeiras1999 = context.Times.FirstOrDefault(t => t.Nome == "Palmeiras 1999");
            if (palmeiras1999 != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Luiz Felipe Scolari",              Cargo = Cargo.Treinador,         DataNascimento = new DateTime(1948, 11,  9), TimeId = palmeiras1999.Id },
                    new ComissaoTecnica { Nome = "Flávio Teixeira",                  Cargo = Cargo.Auxiliar,          DataNascimento = new DateTime(1951,  1, 14), TimeId = palmeiras1999.Id },
                    new ComissaoTecnica { Nome = "Carlos Pacheco",                   Cargo = Cargo.PreparadorFisico,  DataNascimento = new DateTime(1963,  8, 12), TimeId = palmeiras1999.Id },
                    new ComissaoTecnica { Nome = "Antônio Carlos Pracidelli",        Cargo = Cargo.TreinadorGoleiros, DataNascimento = new DateTime(1957,  3,  3), TimeId = palmeiras1999.Id },
                    new ComissaoTecnica { Nome = "Paulo Sérgio Martino Zogaib",      Cargo = Cargo.Fisiologista,      DataNascimento = new DateTime(1957,  1, 24), TimeId = palmeiras1999.Id },
                    new ComissaoTecnica { Nome = "Sérgio Luís de Oliveira",          Cargo = Cargo.Fisioterapeuta,    DataNascimento = new DateTime(1965,  3, 17), TimeId = palmeiras1999.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Gilvan",           DataNascimento = new DateTime(1980, 1, 20), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,    NumeroCamisa = 31, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Marcos",           DataNascimento = new DateTime(1973, 8, 4),  Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,    NumeroCamisa = 1,  Altura = 1.93m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Sérgio",           DataNascimento = new DateTime(1970, 5, 11), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,    NumeroCamisa = 12, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Velloso",          DataNascimento = new DateTime(1968, 9, 22), Nacionalidade = "Brasil", Posicao = Posicao.Goleiro,    NumeroCamisa = 22, Altura = 1.90m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },

                    // Defensores
                    new Jogador { Nome = "Agnaldo Liz",      DataNascimento = new DateTime(1968, 6, 7),  Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,  NumeroCamisa = 8,  Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Francisco Arce",   DataNascimento = new DateTime(1971, 4, 2),  Nacionalidade = "Paraguai", Posicao = Posicao.Lateral, NumeroCamisa = 26, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Cléber",           DataNascimento = new DateTime(1969, 7, 26), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,  NumeroCamisa = 3,  Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Júnior",           DataNascimento = new DateTime(1973, 6, 20), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,  NumeroCamisa = 14, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Júnior Baiano",    DataNascimento = new DateTime(1970, 3, 14), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,  NumeroCamisa = 4,  Altura = 1.92m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Catalino Rivarola",DataNascimento = new DateTime(1965, 4, 30), Nacionalidade = "Paraguai", Posicao = Posicao.Zagueiro,  NumeroCamisa = 6,  Altura = 1.88m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Roque Júnior",     DataNascimento = new DateTime(1976, 8, 31), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro,  NumeroCamisa = 5,  Altura = 1.84m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Rubens Júnior",    DataNascimento = new DateTime(1975, 1, 8),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,  NumeroCamisa = 11, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Esquerdo, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Tiago Silva",      DataNascimento = new DateTime(1979, 4, 4),  Nacionalidade = "Brasil", Posicao = Posicao.Lateral,  NumeroCamisa = 13, Altura = 1.77m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Alex Souza",       DataNascimento = new DateTime(1977, 9, 14), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "César Sampaio",    DataNascimento = new DateTime(1968, 3, 31), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 16, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Ferrugem",         DataNascimento = new DateTime(1980, 10, 6),Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 7,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Galeano",          DataNascimento = new DateTime(1972, 3, 28), Nacionalidade = "Brasil", Posicao = Posicao.Volante, NumeroCamisa = 17, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Jackson",          DataNascimento = new DateTime(1973, 3, 23), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.78m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Juliano",          DataNascimento = new DateTime(1981, 8, 26), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 21, Altura = 1.74m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Rogério",          DataNascimento = new DateTime(1976, 2, 28), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 2,  Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Zinho",            DataNascimento = new DateTime(1967, 6, 17), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 6,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },

                    // Atacantes
                    new Jogador { Nome = "Edmílson",         DataNascimento = new DateTime(1974, 3, 26), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Euller",           DataNascimento = new DateTime(1971, 3, 15), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 17, Altura = 1.75m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Evair",            DataNascimento = new DateTime(1965, 2, 21), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 20, Altura = 1.83m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Oséas",            DataNascimento = new DateTime(1971, 5, 14), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 18, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Paulo Nunes",      DataNascimento = new DateTime(1971, 10, 30),Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 11, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Pena",             DataNascimento = new DateTime(1974, 2, 19), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 19, Altura = 1.76m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },

                    // Jogadores fictícios (43–45)
                    new Jogador { Nome = "Leonardo da Silva",DataNascimento = new DateTime(1976, 9, 10), Nacionalidade = "Brasil", Posicao = Posicao.Meia,    NumeroCamisa = 43, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "André Pereira",    DataNascimento = new DateTime(1978, 5, 22), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 44, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id },
                    new Jogador { Nome = "Carlos Eduardo",   DataNascimento = new DateTime(1977, 12, 1), Nacionalidade = "Brasil", Posicao = Posicao.Atacante,NumeroCamisa = 45, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = palmeiras1999.Id }
                };

                // Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var psg2020 = context.Times.FirstOrDefault(t => t.Nome == "Paris Saint-Germain 2020");
            if (psg2020 != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Thomas Tuchel",       Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1973, 8, 29), TimeId = psg2020.Id },
                    new ComissaoTecnica { Nome = "Jesús Pérez",         Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1970, 4, 9),  TimeId = psg2020.Id },
                    new ComissaoTecnica { Nome = "Miguel D'Agostino",   Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1976, 6, 21), TimeId = psg2020.Id },
                    new ComissaoTecnica { Nome = "Nicolas Dehon",       Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1974, 2, 19), TimeId = psg2020.Id },
                    new ComissaoTecnica { Nome = "Cyril Praud",         Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1975, 12, 5), TimeId = psg2020.Id },
                    new ComissaoTecnica { Nome = "Thierry Laurent",     Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1981, 3, 12), TimeId = psg2020.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Marcin Bułka",         DataNascimento = new DateTime(1999,10,4),  Nacionalidade = "Polônia",   Posicao = Posicao.Goleiro,    NumeroCamisa = 30, Altura = 1.93m, Peso = 90m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Garissone Innocent",  DataNascimento = new DateTime(2000,4,16),  Nacionalidade = "Haiti",     Posicao = Posicao.Goleiro,    NumeroCamisa = 40, Altura = 1.93m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Keylor Navas",        DataNascimento = new DateTime(1986,12,15), Nacionalidade = "Costa Rica",Posicao = Posicao.Goleiro,    NumeroCamisa = 1,  Altura = 1.85m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Sergio Rico",         DataNascimento = new DateTime(1993,9,1),   Nacionalidade = "Espanha",   Posicao = Posicao.Goleiro,    NumeroCamisa = 16, Altura = 1.92m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Sébastien Cibois",    DataNascimento = new DateTime(1998,3,30),  Nacionalidade = "França",    Posicao = Posicao.Goleiro,    NumeroCamisa = 50, Altura = 1.88m, Peso = 84m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },

                    // Defensores
                    new Jogador { Nome = "Thiago Silva",        DataNascimento = new DateTime(1984,9,22),  Nacionalidade = "Brasil",    Posicao = Posicao.Zagueiro,  NumeroCamisa = 2,  Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Presnel Kimpembe",    DataNascimento = new DateTime(1995,8,13),  Nacionalidade = "França",    Posicao = Posicao.Zagueiro,  NumeroCamisa = 3,  Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Thilo Kehrer",        DataNascimento = new DateTime(1996,9,21),  Nacionalidade = "Alemanha",  Posicao = Posicao.Zagueiro,  NumeroCamisa = 4,  Altura = 1.85m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Marquinhos",          DataNascimento = new DateTime(1994,5,14),  Nacionalidade = "Brasil",    Posicao = Posicao.Zagueiro,  NumeroCamisa = 5,  Altura = 1.83m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Thomas Meunier",      DataNascimento = new DateTime(1991,9,29),  Nacionalidade = "Bélgica",   Posicao = Posicao.Zagueiro,  NumeroCamisa = 12, Altura = 1.91m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Juan Bernat",         DataNascimento = new DateTime(1993,3,1),   Nacionalidade = "Espanha",   Posicao = Posicao.Lateral,   NumeroCamisa = 14, Altura = 1.78m, Peso = 67m, PePreferido = PePreferido.Esquerdo, TimeId = psg2020.Id },
                    new Jogador { Nome = "Layvin Kurzawa",      DataNascimento = new DateTime(1992,9,4),   Nacionalidade = "França",    Posicao = Posicao.Lateral,   NumeroCamisa = 20, Altura = 1.83m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = psg2020.Id },
                    new Jogador { Nome = "Abdou Diallo",        DataNascimento = new DateTime(1996,5,4),   Nacionalidade = "Senegal",   Posicao = Posicao.Zagueiro,  NumeroCamisa = 22, Altura = 1.88m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Mitchel Bakker",      DataNascimento = new DateTime(2000,6,20),  Nacionalidade = "Países Baixos", Posicao = Posicao.Lateral,NumeroCamisa = 25, Altura = 1.85m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Colin Dagba",         DataNascimento = new DateTime(1998,9,9),   Nacionalidade = "França",    Posicao = Posicao.Lateral,   NumeroCamisa = 31, Altura = 1.70m, Peso = 62m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Tanguy Nianzou",      DataNascimento = new DateTime(2002,6,7),   Nacionalidade = "França",    Posicao = Posicao.Zagueiro,  NumeroCamisa = 35, Altura = 1.88m, Peso = 83m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Loïc Mbe Soh",        DataNascimento = new DateTime(2001,8,6),   Nacionalidade = "França",    Posicao = Posicao.Zagueiro,  NumeroCamisa = 36, Altura = 1.85m, Peso = 81m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Marco Verratti",      DataNascimento = new DateTime(1992,11,5),  Nacionalidade = "Itália",    Posicao = Posicao.Meia,      NumeroCamisa = 6,  Altura = 1.65m, Peso = 58m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Leandro Paredes",     DataNascimento = new DateTime(1994,6,29),  Nacionalidade = "Argentina", Posicao = Posicao.Meia,      NumeroCamisa = 8,  Altura = 1.80m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Ángel Di María",      DataNascimento = new DateTime(1988,2,14),  Nacionalidade = "Argentina", Posicao = Posicao.Meia,      NumeroCamisa = 11, Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Esquerdo, TimeId = psg2020.Id },
                    new Jogador { Nome = "Pablo Sarabia",       DataNascimento = new DateTime(1992,5,11),  Nacionalidade = "Espanha",   Posicao = Posicao.Meia,      NumeroCamisa = 19, Altura = 1.75m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Ander Herrera",       DataNascimento = new DateTime(1989,8,14),  Nacionalidade = "Espanha",   Posicao = Posicao.Meia,      NumeroCamisa = 21, Altura = 1.83m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Julian Draxler",      DataNascimento = new DateTime(1993,9,20),  Nacionalidade = "Alemanha",  Posicao = Posicao.Meia,      NumeroCamisa = 23, Altura = 1.85m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Idrissa Gueye",       DataNascimento = new DateTime(1989,9,26),  Nacionalidade = "Senegal",   Posicao = Posicao.Meia,      NumeroCamisa = 27, Altura = 1.75m, Peso = 66m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Adil Aouchiche",      DataNascimento = new DateTime(2002,7,15),  Nacionalidade = "França",    Posicao = Posicao.Meia,      NumeroCamisa = 38, Altura = 1.80m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },

                    // Atacantes
                    new Jogador { Nome = "Kylian Mbappé",       DataNascimento = new DateTime(1998,12,20), Nacionalidade = "França",    Posicao = Posicao.Atacante, NumeroCamisa = 7,  Altura = 1.78m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Edinson Cavani",      DataNascimento = new DateTime(1987,2,14),  Nacionalidade = "Uruguai",   Posicao = Posicao.Atacante, NumeroCamisa = 9,  Altura = 1.83m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Neymar",              DataNascimento = new DateTime(1992,2,5),   Nacionalidade = "Brasil",    Posicao = Posicao.Atacante, NumeroCamisa = 10, Altura = 1.75m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Eric Maxim Choupo-Moting", DataNascimento = new DateTime(1989,3,23), Nacionalidade = "Camarões",Posicao = Posicao.Atacante, NumeroCamisa = 17, Altura = 1.91m, Peso = 88m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Mauro Icardi",        DataNascimento = new DateTime(1993,2,19),  Nacionalidade = "Argentina", Posicao = Posicao.Atacante, NumeroCamisa = 18, Altura = 1.80m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Arnaud Kalimuendo",   DataNascimento = new DateTime(2002,1,23),  Nacionalidade = "França",    Posicao = Posicao.Atacante, NumeroCamisa = 33, Altura = 1.78m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                
                    // Jogadores adicionais fictícios
                    new Jogador { Nome = "José da Silva", DataNascimento = new DateTime(1994, 4, 12), Nacionalidade = "Brasil", Posicao = Posicao.Zagueiro, NumeroCamisa = 43, Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = psg2020.Id },
                    new Jogador { Nome = "Miguel Costa", DataNascimento = new DateTime(1993, 5, 18), Nacionalidade = "Portugal", Posicao = Posicao.Meia, NumeroCamisa = 41, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Esquerdo, TimeId = psg2020.Id },

                };

                // Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var atletico2014 = context.Times.FirstOrDefault(t => t.Nome == "Atlético Madrid 2014");
            if (atletico2014 != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Diego Simeone",        Cargo = Cargo.Treinador,          DataNascimento = new DateTime(1970, 4, 28), TimeId = atletico2014.Id },
                    new ComissaoTecnica { Nome = "Germán Burgos",        Cargo = Cargo.Auxiliar,           DataNascimento = new DateTime(1969, 4, 16), TimeId = atletico2014.Id },
                    new ComissaoTecnica { Nome = "Pablo Vercellone",     Cargo = Cargo.TreinadorGoleiros,  DataNascimento = new DateTime(1968, 4, 24), TimeId = atletico2014.Id },
                    new ComissaoTecnica { Nome = "Óscar Ortega",         Cargo = Cargo.PreparadorFisico,   DataNascimento = new DateTime(1958, 3, 29), TimeId = atletico2014.Id },
                    new ComissaoTecnica { Nome = "José María Villalón",  Cargo = Cargo.Fisiologista,       DataNascimento = new DateTime(1960, 1,  1), TimeId = atletico2014.Id }, // placeholder
                    new ComissaoTecnica { Nome = "Óscar Pitillas",       Cargo = Cargo.Fisioterapeuta,     DataNascimento = new DateTime(1975, 1,  1), TimeId = atletico2014.Id }  // placeholder
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Dani Aranzubia",      DataNascimento = new DateTime(1976,10,19), Nacionalidade = "Espanha",  Posicao = Posicao.Goleiro,    NumeroCamisa = 1,  Altura = 1.88m, Peso = 85m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Thibaut Courtois",    DataNascimento = new DateTime(1992,5,11),  Nacionalidade = "Bélgica",  Posicao = Posicao.Goleiro,    NumeroCamisa = 13, Altura = 1.99m, Peso = 96m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Yassine Bounou",      DataNascimento = new DateTime(1991,4,5),   Nacionalidade = "Marrocos", Posicao = Posicao.Goleiro,    NumeroCamisa = 25, Altura = 1.88m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },

                    // Defensores
                    new Jogador { Nome = "Diego Godín",         DataNascimento = new DateTime(1986,2,16),  Nacionalidade = "Uruguai",  Posicao = Posicao.Zagueiro,  NumeroCamisa = 2,  Altura = 1.87m, Peso = 82m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Filipe Luís",         DataNascimento = new DateTime(1985,7,9),   Nacionalidade = "Brasil",   Posicao = Posicao.Zagueiro,  NumeroCamisa = 3,  Altura = 1.68m, Peso = 63m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Toby Alderweireld",   DataNascimento = new DateTime(1989,3,2),   Nacionalidade = "Bélgica",  Posicao = Posicao.Zagueiro,  NumeroCamisa = 12, Altura = 1.87m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Javi Manquillo",       DataNascimento = new DateTime(1991,5,1),   Nacionalidade = "Espanha",  Posicao = Posicao.Zagueiro,  NumeroCamisa = 17, Altura = 1.75m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "José María Giménez",  DataNascimento = new DateTime(1995,1,20),  Nacionalidade = "Uruguai",  Posicao = Posicao.Zagueiro,  NumeroCamisa = 18, Altura = 1.85m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Juanfran Torres",      DataNascimento = new DateTime(1985,1,9),   Nacionalidade = "Espanha",  Posicao = Posicao.Lateral,   NumeroCamisa = 20, Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Emiliano Insúa",       DataNascimento = new DateTime(1989,3,15),  Nacionalidade = "Argentina",Posicao = Posicao.Lateral,   NumeroCamisa = 22, Altura = 1.76m, Peso = 76m, PePreferido = PePreferido.Esquerdo, TimeId = atletico2014.Id },
                    new Jogador { Nome = "João Miranda",         DataNascimento = new DateTime(1984,9,7),   Nacionalidade = "Brasil",   Posicao = Posicao.Zagueiro,  NumeroCamisa = 23, Altura = 1.85m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "Mario Suárez",        DataNascimento = new DateTime(1987,9,24),  Nacionalidade = "Espanha",  Posicao = Posicao.Meia,      NumeroCamisa = 4,  Altura = 1.76m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Tiago Mendes",        DataNascimento = new DateTime(1981,5,2),   Nacionalidade = "Portugal", Posicao = Posicao.Meia,      NumeroCamisa = 5,  Altura = 1.83m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Koke Resurrección",   DataNascimento = new DateTime(1992,1,8),   Nacionalidade = "Espanha",  Posicao = Posicao.Meia,      NumeroCamisa = 6,  Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Raúl García",         DataNascimento = new DateTime(1986,7,11),  Nacionalidade = "Espanha",  Posicao = Posicao.Meia,      NumeroCamisa = 8,  Altura = 1.81m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Arda Turan",          DataNascimento = new DateTime(1987,1,30),  Nacionalidade = "Turquia",  Posicao = Posicao.Meia,      NumeroCamisa = 10, Altura = 1.74m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Cristian Rodríguez",  DataNascimento = new DateTime(1985,9,30),  Nacionalidade = "Uruguai",  Posicao = Posicao.Meia,      NumeroCamisa = 11, Altura = 1.72m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Gabi Fernández",      DataNascimento = new DateTime(1983,7,10),  Nacionalidade = "Espanha",  Posicao = Posicao.Meia,      NumeroCamisa = 14, Altura = 1.76m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Óliver Torres",       DataNascimento = new DateTime(1994,11,10), Nacionalidade = "Espanha",  Posicao = Posicao.Meia,      NumeroCamisa = 16, Altura = 1.78m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Diego Ribas",         DataNascimento = new DateTime(1985,2,28),  Nacionalidade = "Brasil",   Posicao = Posicao.Meia,      NumeroCamisa = 21, Altura = 1.66m, Peso = 62m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "José Sosa",           DataNascimento = new DateTime(1985,9,28),  Nacionalidade = "Argentina",Posicao = Posicao.Meia,      NumeroCamisa = 24, Altura = 1.70m, Peso = 65m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },

                    // Atacantes
                    new Jogador { Nome = "Adrián López",        DataNascimento = new DateTime(1988,9,8),   Nacionalidade = "Espanha",  Posicao = Posicao.Atacante, NumeroCamisa = 7,  Altura = 1.87m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "David Villa",         DataNascimento = new DateTime(1981,12,3),  Nacionalidade = "Espanha",  Posicao = Posicao.Atacante, NumeroCamisa = 9,  Altura = 1.70m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Diego Costa",         DataNascimento = new DateTime(1988,10,7),  Nacionalidade = "Brasil",   Posicao = Posicao.Atacante, NumeroCamisa = 19, Altura = 1.88m, Peso = 89m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },

                    // Jogadores fictícios (25–30)
                    new Jogador { Nome = "Pedro Martínez",      DataNascimento = new DateTime(1990,3,3),   Nacionalidade = "Espanha",  Posicao = Posicao.Zagueiro,  NumeroCamisa = 43, Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Miguel Santos",       DataNascimento = new DateTime(1992,5,5),   Nacionalidade = "Espanha",  Posicao = Posicao.Lateral,   NumeroCamisa = 44, Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Javier Gómez",        DataNascimento = new DateTime(1991,7,7),   Nacionalidade = "Espanha",  Posicao = Posicao.Meia,      NumeroCamisa = 45, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Ricardo Vargas",      DataNascimento = new DateTime(1993,8,8),   Nacionalidade = "Espanha",  Posicao = Posicao.Volante,   NumeroCamisa = 46, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Sergio Castillo",     DataNascimento = new DateTime(1994,9,9),   Nacionalidade = "Espanha",  Posicao = Posicao.Atacante, NumeroCamisa = 47, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id },
                    new Jogador { Nome = "Alberto Ruiz",        DataNascimento = new DateTime(1995,10,10), Nacionalidade = "Espanha",  Posicao = Posicao.Atacante, NumeroCamisa = 48, Altura = 1.81m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = atletico2014.Id }
                };

                // Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }

            var benfica1962 = context.Times.FirstOrDefault(t => t.Nome == "Benfica 1962");
            if (benfica1962 != null)
            {

                var comissao = new List<ComissaoTecnica>
                {
                    new ComissaoTecnica { Nome = "Béla Guttmann", Cargo = Cargo.Treinador, DataNascimento = new DateTime(1899, 1, 27), TimeId = benfica1962.Id },
                    new ComissaoTecnica { Nome = "Fernando Cabrita", Cargo = Cargo.Auxiliar, DataNascimento = new DateTime(1923, 5, 1), TimeId = benfica1962.Id },
                    new ComissaoTecnica { Nome = "Carlos Pinto", Cargo = Cargo.PreparadorFisico, DataNascimento = new DateTime(1925, 8, 15), TimeId = benfica1962.Id },
                    new ComissaoTecnica { Nome = "José Duarte", Cargo = Cargo.Fisiologista, DataNascimento = new DateTime(1930, 4, 10), TimeId = benfica1962.Id },
                    new ComissaoTecnica { Nome = "António Silva", Cargo = Cargo.TreinadorGoleiros, DataNascimento = new DateTime(1928, 12, 3), TimeId = benfica1962.Id },
                    new ComissaoTecnica { Nome = "Manuel Almeida", Cargo = Cargo.Fisioterapeuta, DataNascimento = new DateTime(1932, 7, 22), TimeId = benfica1962.Id }
                };

                comissao.ForEach(c => context.ComissaoTecnica.AddOrUpdate(ct => new { ct.Nome, ct.Cargo }, c));
                context.SaveChanges();

                var jogadores = new List<Jogador>
                {
                    // Goleiros
                    new Jogador { Nome = "Costa Pereira",        DataNascimento = new DateTime(1929,9,27), Nacionalidade = "Portugal", Posicao = Posicao.Goleiro,    NumeroCamisa = 1,  Altura = 1.85m, Peso = 80m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "José Barroca",         DataNascimento = new DateTime(1933,4,2),  Nacionalidade = "Portugal", Posicao = Posicao.Goleiro,    NumeroCamisa = 12, Altura = 1.83m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Armando Ramalho",      DataNascimento = new DateTime(1935,2,14), Nacionalidade = "Portugal", Posicao = Posicao.Goleiro,    NumeroCamisa = 22, Altura = 1.82m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },

                    // Defensores
                    new Jogador { Nome = "Fernando Cruz",        DataNascimento = new DateTime(1940,7,26), Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 2,  Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Manuel Serra",         DataNascimento = new DateTime(1938,11,15),Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 3,  Altura = 1.80m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Mário João",           DataNascimento = new DateTime(1935,10,8), Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 4,  Altura = 1.82m, Peso = 78m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Ângelo Martins",       DataNascimento = new DateTime(1937,3,14), Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 5,  Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Germano de Figueiredo",DataNascimento = new DateTime(1932,3,23), Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 6,  Altura = 1.84m, Peso = 79m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Sidónio Manhiça",      DataNascimento = new DateTime(1939,5,5),  Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 7,  Altura = 1.79m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Jorge Nogueira",       DataNascimento = new DateTime(1939,9,12), Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 8,  Altura = 1.77m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "José Neto",            DataNascimento = new DateTime(1937,2,24), Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 9,  Altura = 1.81m, Peso = 77m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Manuel Pinto",         DataNascimento = new DateTime(1938,8,2),  Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 10, Altura = 1.80m, Peso = 76m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Humberto Fernandes",   DataNascimento = new DateTime(1936,6,30), Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 11, Altura = 1.79m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Amândio Gonçalves",    DataNascimento = new DateTime(1938,12,5),Nacionalidade = "Portugal", Posicao = Posicao.Zagueiro,  NumeroCamisa = 23, Altura = 1.78m, Peso = 75m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },

                    // Meio‑campistas
                    new Jogador { Nome = "António Fonseca",      DataNascimento = new DateTime(1939,1,16), Nacionalidade = "Portugal", Posicao = Posicao.Volante, NumeroCamisa = 6,  Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Mário Coluna",         DataNascimento = new DateTime(1927,2,6),  Nacionalidade = "Portugal", Posicao = Posicao.Volante, NumeroCamisa = 7,  Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "José Augusto",         DataNascimento = new DateTime(1935,5,13), Nacionalidade = "Portugal", Posicao = Posicao.Meia,    NumeroCamisa = 8,  Altura = 1.76m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "António Saraiva",      DataNascimento = new DateTime(1936,11,14),Nacionalidade = "Portugal", Posicao = Posicao.Meia,    NumeroCamisa = 9,  Altura = 1.74m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "António Simões",       DataNascimento = new DateTime(1943,12,14),Nacionalidade = "Portugal", Posicao = Posicao.Meia,    NumeroCamisa = 10, Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Jorge Calado",         DataNascimento = new DateTime(1942,7,18), Nacionalidade = "Portugal", Posicao = Posicao.Meia,    NumeroCamisa = 11, Altura = 1.74m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Domiciano Cavém",      DataNascimento = new DateTime(1927,9,21), Nacionalidade = "Portugal", Posicao = Posicao.Meia,    NumeroCamisa = 12, Altura = 1.79m, Peso = 73m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },

                    // Atacantes
                    new Jogador { Nome = "José Águas",           DataNascimento = new DateTime(1930,12,9), Nacionalidade = "Portugal", Posicao = Posicao.Atacante,NumeroCamisa = 9,  Altura = 1.76m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "José Torres",          DataNascimento = new DateTime(1938,12,28),Nacionalidade = "Portugal", Posicao = Posicao.Atacante,NumeroCamisa = 10, Altura = 1.80m, Peso = 74m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Santana",              DataNascimento = new DateTime(1936,4,28), Nacionalidade = "Portugal", Posicao = Posicao.Atacante,NumeroCamisa = 11, Altura = 1.75m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Eusébio",              DataNascimento = new DateTime(1942,1,25), Nacionalidade = "Portugal", Posicao = Posicao.Atacante,NumeroCamisa = 12, Altura = 1.74m, Peso = 68m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "António Mendes",       DataNascimento = new DateTime(1939,2,2),                                          Posicao = Posicao.Atacante,NumeroCamisa = 13, Altura = 1.78m, Peso = 71m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Carlos Angeja",        DataNascimento = new DateTime(1940,8,28), Nacionalidade = "Portugal", Posicao = Posicao.Atacante,NumeroCamisa = 14, Altura = 1.77m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Nartanga",             DataNascimento = new DateTime(1941,3,15), Nacionalidade = "Portugal", Posicao = Posicao.Atacante,NumeroCamisa = 15, Altura = 1.76m, Peso = 70m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },
                    new Jogador { Nome = "Alfredo Espírito Santo",DataNascimento = new DateTime(1940,11,2), Nacionalidade = "Portugal", Posicao = Posicao.Atacante,NumeroCamisa = 16, Altura = 1.75m, Peso = 69m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id },

                    // Jogador fictício (30)
                    new Jogador { Nome = "Pedro Fernandes",      DataNascimento = new DateTime(1941,9,9),  Nacionalidade = "Portugal", Posicao = Posicao.Meia,    NumeroCamisa = 30, Altura = 1.78m, Peso = 72m, PePreferido = PePreferido.Direito, TimeId = benfica1962.Id }
                };

                // Insere ou atualiza sem duplicar
                jogadores.ForEach(j => context.Jogadores.AddOrUpdate(p => new { p.Nome, p.NumeroCamisa }, j));
                context.SaveChanges();
            }
        }
    }
}