/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder mover la elice del avión
**/



// IMportaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerElice : MonoBehaviour
{   
    // Variable tipo float que guarda la velocidad del giro
    public float velocidadGiro = 1200.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Realiza el movimiento de la elice del avion.
        transform.Rotate(Vector3.forward * velocidadGiro);
    }
}
