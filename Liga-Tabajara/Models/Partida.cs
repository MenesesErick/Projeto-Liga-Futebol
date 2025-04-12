using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Tabajara.Models
{
    public class Partida
    {

        [Key]
        public int PartidaId { get; set; }

        [Required]
        public DateTime DataPartida { get; set; }

        [Required]
        [MaxLength(100)]
        public string Estadio { get; set; }

        // Chave estrangeira para o Time Mandante
        [ForeignKey("TimeMandante")]
        public int TimeMandanteId { get; set; }
        public virtual Time TimeMandante { get; set; }

        // Chave estrangeira para o Time Visitante
        [ForeignKey("TimeVisitante")]
        public int TimeVisitanteId { get; set; }
        public virtual Time TimeVisitante { get; set; }

        // Placar dos times (pode ser nulo até o registro do resultado)
        public int? PlacarTimeMandante { get; set; }
        public int? PlacarTimeVisitante { get; set; }

        // Relação com os gols marcados na partida
        public virtual ICollection<Gol> Gols { get; set; }

        public Partida()
        {
            Gols = new List<Gol>();
        }
    }
}