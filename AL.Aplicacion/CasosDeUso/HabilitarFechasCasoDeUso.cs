using System;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.CasosDeUso;

public class HabilitarFechasCasoDeUso : AlojamientoCasoDeUso
{
    public HabilitarFechasCasoDeUso(IAlojamientoRepositorio repo) : base(repo) { }

    public void Ejecutar(int alojamientoId, DateTime desde, DateTime hasta)
    {
        Repositorio.HabilitarPeriodo(alojamientoId, desde, hasta);
    }
}
