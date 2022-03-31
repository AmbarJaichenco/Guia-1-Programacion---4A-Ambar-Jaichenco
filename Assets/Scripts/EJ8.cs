using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ8 : MonoBehaviour
{
    //    Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que
    //el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
    //valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
    //mensaje de error "El día ingresado no es válido"

    public int dia;

    // Start is called before the first frame update
    void Start()
    {
        string nombredia = "";
        switch (dia)
        {
            case 1:
                nombredia = "Domingo";
                break;
            case 2:
                nombredia = "Lunes";
                break;
            case 3:
                nombredia = "Martes";
                break;
            case 4:
                nombredia = "Miercoles";
                break;
            case 5:
                nombredia = "Jueves";
                break;
            case 6:
                nombredia = "Viernes";
                break;
            case 7:
                nombredia = "Sabado";
                break;
            default:
                Debug.Log("El día ingresado no es válido");
                break;
        }
        Debug.Log(nombredia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
