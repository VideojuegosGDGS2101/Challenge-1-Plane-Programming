/**
Autor: Oscar David Castañeda Rivera
Grupo: GDGS2091
Materia: Creación de videojuegos
**/

/**
Script encargado de poder mover la cámara la cual
irá siguiendo el movimiento del avión
**/

// Importaciones
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // Variable tipo GameObject
    public GameObject plane;

    // se crea una nueva instancia de Vector3
    private Vector3 offset = new Vector3(30,0,10);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Codigo que realiza el movimiento de la camara para dar seguimiento al avion
        transform.position = plane.transform.position + offset;
    }
}
