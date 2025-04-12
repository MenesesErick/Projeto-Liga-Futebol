using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Liga_Tabajara.Models
{
    public class ComissaoTecnica
    {
        public enum CargoComissao
        {
            Treinador,
            Auxiliar,
            PreparadorFisico,
            Fisiologista,
            TreinadorDeGoleiros,
            Fisioterapeuta
        }

        [Key]
        public int ComissaoTecnicaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public CargoComissao Cargo { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        // Chave estrangeira para o Time
        [ForeignKey("Time")]
        public int TimeId { get; set; }
        public virtual Time Time { get; set; }
    }
}