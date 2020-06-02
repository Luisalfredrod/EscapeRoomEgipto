using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre_Lili : MonoBehaviour
{
    bool cajaAbriendose;
    bool cajaCerrada;

    public GameObject tapa;
    public AudioSource sonido;

    float inc;
    float anguloActual;

    // Start is called before the first frame update
    void Start()
    {
        cajaAbriendose = false;
        cajaCerrada = true;
        inc = -0.8f;

        anguloActual = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (cajaAbriendose)
        {
            tapa.transform.Rotate(inc, 0, 0);
            anguloActual += inc;

            if (cajaCerrada)
            {
                inc = -0.8f;
                if (anguloActual <= -100)
                {
                    cajaAbriendose = false;
                    cajaCerrada = false;
                }
            }
            else
            {
                inc = 0.8f;
                if (anguloActual >= 0)
                {
                    cajaAbriendose = false;
                    cajaCerrada = true;
                }
            }



        }

    }
    private void OnTriggerEnter(Collider other)
    {
        cajaAbriendose = true;
        sonido.Play();
    }
}

