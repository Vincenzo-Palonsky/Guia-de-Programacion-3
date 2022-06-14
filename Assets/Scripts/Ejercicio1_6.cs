using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_6 : MonoBehaviour
{
    public string cadena;
    public int cantVeces;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            EscribirCadena(cadena, cantVeces);
        }
    }

    bool EscribirCadena(string cadena, int cantVeces)
    {
        bool mayorDeCero = true;
        if (cantVeces <= 0)
        {
            Debug.Log("Error, la cantidad de veces debe ser mayor a 0");
            mayorDeCero = false;
            return (mayorDeCero);
        }

        else
        {
            for (int i=0; i<cantVeces; i++)
            {
                Debug.Log(cadena);
            }
            return (mayorDeCero);
        }
    }
}
