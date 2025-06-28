using System;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.CasosDeUso;

public class DeshabilitarFechasCasoDeUso : AlojamientoCasoDeUso
{
    public DeshabilitarFechasCasoDeUso(IAlojamientoRepositorio repo) : base(repo) { }

    public void Ejecutar(int alojamientoId, DateTime desde, DateTime hasta)
    {
        Repositorio.DeshabilitarPeriodo(alojamientoId, desde, hasta);
    }
}
