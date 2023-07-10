using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Salto : IComando
{
    private float _Fuerza = 15f;
    private bool _Saltando = false;

    void IComando.Ejecutar(GameObject pActor)
    {
        float salto = _Fuerza;

        if (Input.GetButtonDown("Jump"))
        {
            pActor.GetComponent<Rigidbody2D>().velocity = new Vector2(pActor.GetComponent<Rigidbody2D>().velocity.x, _Fuerza);

        }

    }
    

   
}