using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuertaMel : MonoBehaviour
{
    static bool puertaAbriendose;
    bool puertaCerrada;

    public GameObject puerta; //aqui voy a aventar la puerta


    float inc;
    float anguloActual;

    // Start is called before the first frame update
    void Start()
    {
        puertaAbriendose = false;
        puertaCerrada = true;
        inc = -0.95f;

        anguloActual = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (puertaAbriendose)
        {
            puerta.transform.Rotate(0, inc, 0);
            anguloActual += inc;


        }

    }
    public static void triggerCode()
    {
        puertaAbriendose = true;
    }



}