/*using System.Collections.Generic;

public class Personaje
{
    private List<IHabilidad> habilidades = new List<IHabilidad>();
    private HabilidadDash habilidadDash;

    public void AgregarHabilidad(HabilidadBuilder builder)
    {
        builder.ConstruirHabilidad();
        IHabilidad habilidad = builder.ObtenerHabilidad();
        habilidades.Add(habilidad);

        if (habilidad is HabilidadDash dash)
        {
            habilidadDash = dash;
        }
    }

    public HabilidadDash ObtenerHabilidadDash()
    {
        return habilidadDash;
    }

}*/