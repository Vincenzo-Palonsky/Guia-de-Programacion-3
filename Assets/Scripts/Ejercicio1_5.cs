using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_5 : MonoBehaviour
{
    public int num1, num2, num3;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            EscribirCadenaEnConsola(MayorDeTres(num1, num2, num3).ToString());
        }
    }

    void EscribirCadenaEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }

    int MayorDeTres(int num1, int num2, int num3)
    {
        if (num1==num2 && num1==num3)
        {
            return (-1);
        }

        else if (num1>num2)
        {
            if (num1>num3)
            {
                return (num1);
            }

            else
            {
                return (num3);
            }
        }

        else if (num2>num3)
        {
            return (num2);
        }

        else
        {
            return (num3);
        }
    }
}
