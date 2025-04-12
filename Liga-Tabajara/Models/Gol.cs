using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Tabajara.Models
{
    public class Gol
    {

        [Key]
        public int GolId { get; set; }

        // Chave estrangeira para a Partida
        [ForeignKey("Partida")]
        public int PartidaId { get; set; }
        public virtual Partida Partida { get; set; }

        // Chave estrangeira para o Jogador que marcou o gol
        [ForeignKey("Jogador")]
        public int JogadorId { get; set; }
        public virtual Jogador Jogador { get; set; }

        // Opcional: o minuto do gol
        public int? Minuto { get; set; }

    }
}