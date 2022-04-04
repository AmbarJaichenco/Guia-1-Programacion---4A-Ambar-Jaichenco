using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ9 : MonoBehaviour
{
    //Realizá un programa que resuelva el siguiente problema:
    //Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
    //total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
    //por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
    //mostrar lo pedido en el siguiente formato:
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

    // Start is called before the first frame update

    public string persona1 = "";
    public string persona2 = "";
    public string persona3 = "";

    public float cap1 = 0;
    public float cap2 = 0;
    public float cap3 = 0;
    public float captotal;

    void Start()
    {
        captotal = cap1 + cap2 + cap3;
        float porc1 = cap1/captotal * 100;
        float porc2 = cap2 / captotal * 100;
        float porc3 = cap3 / captotal * 100;

        Debug.Log("Nombre: " + persona1 + "capital aportado $" + cap1 + ", Porcentaje del capital %" + porc1 + ", Monto total aportado " + captotal);
        Debug.Log("Nombre: " + persona2 + "capital aportado $" + cap2 + ", Porcentaje del capital %" + porc2 + ", Monto total aportado " + captotal);
        Debug.Log("Nombre: " + persona3 + "capital aportado $" + cap3 + ", Porcentaje del capital %" + porc3 + ", Monto total aportado " + captotal);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
