using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Tabajara.Models
{
    public class Jogador
    {
        public enum Posicao
        {
            Goleiro,
            Zagueiro,
            Volante,
            Meia,
            Atacante,
            // Outros podem ser adicionados conforme necessidade
        }

        public enum PePreferido
        {
            Esquerdo,
            Direito,
            Ambidestro
        }

        [Key]
        public int JogadorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nacionalidade { get; set; }

        [Required]
        public Posicao funcao { get; set; }

        [Required]
        public int NumeroCamisa { get; set; }

        [Required]
        public decimal Altura { get; set; } // em metros

        [Required]
        public decimal Peso { get; set; } // em Kg

        [Required]
        public PePreferido peDominante { get; set; }

        // Chave estrangeira para o Time
        [ForeignKey("Time")]
        public int TimeId { get; set; }
        public virtual Time Time { get; set; }

        // Relação com os gols marcados pelo jogador
        public virtual ICollection<Gol> Gols { get; set; }

        public Jogador()
        {
            Gols = new List<Gol>();
        }
    }
}