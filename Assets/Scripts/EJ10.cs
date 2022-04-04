using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ10 : MonoBehaviour
{
    //Realizá un programa que resuelva el siguiente problema: Nos piden desarrollar un
    //programa que informe si un estacionamiento se encuentra o no abierto según la hora
    //ingresada por el usuario.
    //Nosotros sabemos que el estacionamiento se encuentra abierto entre las 10 y las 18hs.
    //(Crear constante HORA_APERTURA = 10, y HORA_CIERRE = 18).
    //Al iniciar el programa, se tomará como hora actual el valor de una variable expuesta en el
    //Inspector, y deberemos setear una variable booleana llamada estaAbierto en true o false,
    //según corresponda, e informar por pantalla mediante la misma si el estacionamiento se
    //encuentra abierto o no.Obs: En el caso de que el valor de la variable correspona a una hora
    //menor a 0 o mayor a 24, mostrar el mensaje: “Ha ingresado una hora incorrecta”

    int hora_Aperturea = 10;
    int hora_Cierre = 18;
    public int hora_Actual = 0;

    // Start is called before the first frame update
    void Start()
    {
        bool estaAbierto;

        if (hora_Actual <0 || hora_Actual > 24)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }

        else if (hora_Actual >hora_Aperturea && hora_Actual < hora_Cierre)
        {
            estaAbierto = true;
            Debug.Log("El estacionamiento esta abierto");
        }

        else
        {
            estaAbierto = false;
            Debug.Log("El estacionamiento no esta abierto");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
