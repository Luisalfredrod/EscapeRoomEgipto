using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AriLogicaJuego : MonoBehaviour
{
    public static bool[] estadoElementos = { false, false, false };

    public static bool verificar()
    {
        if (estadoElementos[0] == true && estadoElementos[1] == true && estadoElementos[2] == true)
        {
            return true;
        }
        else {
            return false;
        }
    }

}
