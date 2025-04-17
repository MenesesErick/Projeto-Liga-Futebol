using System.ComponentModel.DataAnnotations;
using System;

public enum Posicao
{
    Goleiro,
    Zagueiro,
    Lateral,
    Volante,
    Meia,
    Atacante
}

public enum PePreferido
{
    Esquerdo,
    Direito,
    Ambidestro
}
public class Jogador
{

    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    public string Nacionalidade { get; set; }

    public Posicao Posicao { get; set; } // Usando enum interno

    [Range(1, 99)]
    [Display(Name = "Número da Camisa")]
    public int NumeroCamisa { get; set; }

    public decimal Altura { get; set; }
    public decimal Peso { get; set; }

    [Display(Name = "Pé Preferido")]
    public PePreferido PePreferido { get; set; } // Usando enum interno

    // Foreign Key
    public int TimeId { get; set; }
    public virtual Time Time { get; set; }
}