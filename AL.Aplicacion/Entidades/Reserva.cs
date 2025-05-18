using System;

namespace AL.Aplicacion.Entidades;

public class Reserva
{
    public int Id { get; set; }
    public DateTime FechaInicioEstadia { get; set; }
    public DateTime FechaFinEstadia { get; set; }
    public double MontoEstadia { get; set; }
    public String? EstadoCheckOut { get; set; }
    public int CantidadDeAdultos { get; set; }
    public int CantidadDeNiños { get; set; }
    public Alojamiento? Alojamiento { get; set; }
    public List<String>? ListaInformacionAdicional { get; set; }
    
}
