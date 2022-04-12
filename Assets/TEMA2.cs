using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMA2 : MonoBehaviour
{
    public int monto = 0;
    public string pasaje = "";
    
    void Start()
    {
        int dolares = monto / 200;
        int reales = monto / 24;
        int euros = monto / 210;

        if (monto < 1000)
        {
            Debug.Log("El monot tiene que ser mayor a 1000");
        } else if (monto > 1000)
        {
            switch (pasaje)
            {
                case "D": Debug.Log(monto + "pesos argentinos es igual a '" + dolares + "' dolares");
                    break;
                case "R": Debug.Log(monto + "pesos argentinos es igual a '" + reales + "' reales");
                    break;
                case "E": Debug.Log(monto + "pesos argentinos es igual a '" + euros + "' euros");
                    break;
                default: Debug.Log("La moneda ingresada no existe");
                    break;
            }
        }

    }

   
}
