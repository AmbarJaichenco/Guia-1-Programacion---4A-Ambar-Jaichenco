using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ4 : MonoBehaviour
{
    ///  Realizá un programa que permita ingresar dos números enteros num1 y num2 por Inspector.
    ///  Luego, mostrar el resultado de la suma entre ambos al ejecutar la escena utilizando el siguiente formato: 
    ///  “La  suma entre “ + num1 + “ y “ + num2 + “ da como resultado “ + num1 + num2. 

    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        int resultado;
        resultado = num1 + num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " da como resultado " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
