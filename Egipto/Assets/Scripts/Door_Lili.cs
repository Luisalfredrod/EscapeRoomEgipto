﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Lili : MonoBehaviour
{
    bool puertaAbriendose;
    bool puertaCerrada;

    public GameObject tapapuerta;
    public AudioSource sonido;

    float inc;
    float anguloActual;

    // Start is called before the first frame update
    void Start()
    {
        puertaAbriendose = false;
        puertaCerrada = true;
        inc = -0.1f;

        anguloActual = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (puertaAbriendose)
        {
            tapapuerta.transform.Translate(0, inc, 0);
            anguloActual += inc;
            

            if (puertaCerrada)
            {

                inc = -0.1f;
                if (anguloActual <= -10)
                {

                    puertaAbriendose = false;
                    puertaCerrada = false;
                    {
                        Destroy(gameObject);
                    }

                }
            }
            else
            {
                inc = 0.1f;
                if (anguloActual >= 0)
                {
                    puertaAbriendose = false;
                    puertaCerrada = true;
                }
            }



        }

    }
    private void OnMouseDown()
    {
        puertaAbriendose = true;
        sonido.Play();
        
    }
}