using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

public class Partida
{
    public int Id { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime DataHora { get; set; }

    public int TimeCasaId { get; set; }
    public int TimeVisitanteId { get; set; }

    [ForeignKey("TimeCasaId")]
    public virtual Time TimeCasa { get; set; }

    [ForeignKey("TimeVisitanteId")]
    public virtual Time TimeVisitante { get; set; }

    public int? GolsCasa { get; set; }
    public int? GolsVisitante { get; set; }

    public virtual ICollection<Gol> Gols { get; set; }
}