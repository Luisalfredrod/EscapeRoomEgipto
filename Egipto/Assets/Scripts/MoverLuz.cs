using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MoverLuz : MonoBehaviour
{
    float incX = 0.001f;

    void FixedUpdate()
    {
        if (LogicaJuego_reloj.corriendoTiempo)
        {
            gameObject.transform.Translate(new Vector3(incX, 0, 0));
            

                if (gameObject.transform.position.x > -43)
                    LogicaJuego_reloj.corriendoTiempo = false;
            
        }
    }

   
    }

