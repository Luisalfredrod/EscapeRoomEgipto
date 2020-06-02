using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaJuego_reloj : MonoBehaviour
{
    public static bool corriendoTiempo = false;

    private void OnMouseDown()
    {
        corriendoTiempo = true;
    }
        
}
