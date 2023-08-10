using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    private InputHandler _inputH;
    /*private Personaje miPersonaje;*/

    void Start()
    {
        _inputH = new InputHandler();
        /*miPersonaje = new Personaje();

        
        float dashSpeed = 250f; 
        HabilidadBuilder builderDash = new HabilidadDashBuilder(dashSpeed);
        miPersonaje.AgregarHabilidad(builderDash);*/
    }

    void Update()
    {

        //_inputH.UpdateInput();

        if (_inputH.HandleInput() != null)
        {
            IComando _cmd = _inputH.HandleInput();
            _cmd.Ejecutar(ComandosRegistrados._PersonajeSeleccionado);
        }



        // Verificar si el jugador presiona la tecla Shift para activar el Dash
   /*     if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // Obtener la habilidad de Dash y ejecutarla si existe
            HabilidadDash habilidadDash = miPersonaje.ObtenerHabilidadDash();
            if (habilidadDash != null)
            {
                habilidadDash.Ejecutar(ComandosRegistrados._PersonajeSeleccionado);
            }
        }*/
    }
}