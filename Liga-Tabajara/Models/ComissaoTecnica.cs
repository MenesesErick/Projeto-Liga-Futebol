using System.ComponentModel.DataAnnotations;
using System;

public enum Cargo
{
    Treinador,
    Auxiliar,
    PreparadorFisico,
    Fisiologista,
    TreinadorGoleiros,
    Fisioterapeuta
}
public class ComissaoTecnica
{

    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    public Cargo Cargo { get; set; } // Usando enum interno

    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    // Foreign Key
    public int TimeId { get; set; }
    public virtual Time Time { get; set; }
}