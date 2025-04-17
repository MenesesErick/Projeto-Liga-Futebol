using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



public class Time
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    public string Cidade { get; set; }

    [Required]
    public string Estado { get; set; }

    [Display(Name = "Ano de Fundação")]
    public int AnoFundacao { get; set; }

    public string Estadio { get; set; }

    [Display(Name = "Capacidade do Estádio")]
    public int CapacidadeEstadio { get; set; }

    [Display(Name = "Cor Primária")]
    public string CorUniformePrincipal { get; set; }

    [Display(Name = "Cor Secundária")]
    public string CorUniformeSecundario { get; set; }

    public bool Status { get; set; } = false;

    // Relações
    public virtual ICollection<Jogador> Jogadores { get; set; }
    public virtual ICollection<ComissaoTecnica> Comissao { get; set; }
}

