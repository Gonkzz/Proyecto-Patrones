/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HabilidadBuilder
{
    protected IHabilidad habilidad;

    public abstract void ConstruirHabilidad();

    public IHabilidad ObtenerHabilidad()
    {
        return habilidad;
    }
}

public class HabilidadDisparoBuilder : HabilidadBuilder
{
    public override void ConstruirHabilidad()
    {
        habilidad = new HabilidadDisparo(); // Clase concreta que implementa IHabilidad
    }
}
public class HabilidadDashBuilder : HabilidadBuilder
{
    private float dashSpeed;

    public HabilidadDashBuilder(float dashSpeed)
    {
        this.dashSpeed = dashSpeed;
    }

    public override void ConstruirHabilidad()
    {
        habilidad = new HabilidadDash(dashSpeed);
    }
}*/