using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;


public class Gol
{
    public int GolId { get; set; }
    public int JogadorId { get; set; }
    public int PartidaId { get; set; }
    public int Minuto { get; set; }

    public int Quantidade { get; set; }

    public virtual Jogador Jogador { get; set; }
    public virtual Partida Partida { get; set; }
}