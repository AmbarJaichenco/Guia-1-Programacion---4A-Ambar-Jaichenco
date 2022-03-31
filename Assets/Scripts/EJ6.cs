using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ6 : MonoBehaviour
{
//    Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
//en una variable llamada num1 y muestre un mensaje por pantalla indicando &quot;el número es
//par&quot; o &quot;el número es impar&quot;. Deberá utilizar el operador “módulo” es el caracter %.

   public int num1; 

    void Start()
    {
        if(num1 % 2 == 0)
        {
            Debug.Log("Es un número par");
        }
        else
        {
            Debug.Log("Es un numero impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
