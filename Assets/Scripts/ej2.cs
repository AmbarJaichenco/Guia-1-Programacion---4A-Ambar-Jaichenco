using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{
    //Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,
    //respectivamente, realice la operación correspondiente y muestre el resultado en pantalla:
    //a.Suma
    //b.Producto

    int num1;
    int num2;

    // Start is called before the first frame update
    void Start()
    {
        num1 = 4;
        num2 = 5;

        int rtasuma;
        int rtaproducto;

        rtasuma = num1 + num2;
        Debug.Log(rtasuma);

        rtaproducto = num1 * num2;
        Debug.Log(rtaproducto);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
