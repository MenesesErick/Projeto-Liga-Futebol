using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Liga_Tabajara.Models
{
    public class Time
    {
        [Key]
        public int TimeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; }

        [Required]
        public int AnoFundacao { get; set; }

        [Required]
        [MaxLength(100)]
        public string Estadio { get; set; }

        [Required]
        public int CapacidadeEstadio { get; set; }

        [Required]
        [MaxLength(50)]
        public string CorUniformePrimaria { get; set; }

        [Required]
        [MaxLength(50)]
        public string CorUniformeSecundaria { get; set; }

        // Status para indicar se o time está apto a participar da liga
        public bool Status { get; set; }

        // Navegação para jogadores e comissão técnica
        public virtual ICollection<Jogador> Jogadores { get; set; }
        public virtual ICollection<ComissaoTecnica> ComissoesTecnicas { get; set; }

        // Navegação para partidas disputadas em casa e fora
        public virtual ICollection<Partida> PartidasComoMandante { get; set; }
        public virtual ICollection<Partida> PartidasComoVisitante { get; set; }

        public Time()
        {
            Jogadores = new List<Jogador>();
            ComissoesTecnicas = new List<ComissaoTecnica>();
            PartidasComoMandante = new List<Partida>();
            PartidasComoVisitante = new List<Partida>();
        }
    }

}